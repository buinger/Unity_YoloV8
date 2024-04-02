using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Barracuda;
using UnityEngine;
using UnityEngine.Profiling;

namespace NN
{
    public class YOLOv8
    {
        protected YOLOv8OutputReader outputReader; // YOLOv8输出读取器

        private NNHandler nn; // 神经网络处理器

        public YOLOv8(NNHandler nn)
        {
            this.nn = nn;
            outputReader = new YOLOv8OutputReader(); // 初始化输出读取器
        }

        public List<ResultBox> Run(Texture2D image)
        {
            Profiler.BeginSample("YOLO.Run"); // 开始性能采样
            var outputs = ExecuteModel(image); // 执行模型
            var results = Postprocess(outputs); // 后处理输出结果
            Profiler.EndSample(); // 结束性能采样
            return results; // 返回结果
        }

        protected Tensor[] ExecuteModel(Texture2D image)
        {
            Tensor input = new Tensor(image); // 创建输入张量
            ExecuteBlocking(input); // 执行模型
            input.tensorOnDevice.Dispose(); // 释放设备上的张量
            return PeekOutputs().ToArray(); // 返回输出张量数组
        }

        private void ExecuteBlocking(Tensor preprocessed)
        {
            Profiler.BeginSample("YOLO.Execute"); // 开始性能采样
            nn.worker.Execute(preprocessed); // 执行神经网络处理器
            nn.worker.FlushSchedule(blocking: true); // 刷新调度
            Profiler.EndSample(); // 结束性能采样
        }

        private IEnumerable<Tensor> PeekOutputs()
        {
            foreach (string outputName in nn.model.outputs)
            {
                Tensor output = nn.worker.PeekOutput(outputName); // 获取输出张量
                yield return output; // 返回输出张量
            }
        }

        protected List<ResultBox> Postprocess(Tensor[] outputs)
        {
            Profiler.BeginSample("YOLOv8Postprocessor.Postprocess"); // 开始性能采样
            Tensor boxesOutput = outputs[0]; // 获取输出张量
            List<ResultBox> boxes = outputReader.ReadOutput(boxesOutput).ToList(); // 读取输出
            boxes = DuplicatesSupressor.RemoveDuplicats(boxes); // 移除重复项
            Profiler.EndSample(); // 结束性能采样
            return boxes; // 返回结果列表
        }
    }
}
