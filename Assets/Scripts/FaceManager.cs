using System;
using System.Collections;
using System.Collections.Generic;
using NN;
using UnityEngine;
using com.baidu.ai;
using com.baidu.ai.search;
using System.Threading.Tasks;

public class FaceManager : MonoBehaviour
{
    public static FaceManager instance;

    public float maxDisOffset = 100f;
    List<FaceInfo> nowFaces = new List<FaceInfo>();

    private Queue<FaceInfo> waitForDateFaces = new Queue<FaceInfo>();


    private void Start()
    {
        instance = this;
    }

    void OnEnable()
    {
        StartCoroutine(GetFaceDate());
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator GetFaceDate()
    {
        nowFaces.Clear();
        waitForDateFaces.Clear();
        while (true)
        {
            if (waitForDateFaces.Count != 0)
            {
                FaceInfo targetFace = waitForDateFaces.Dequeue();
                if (nowFaces.Contains(targetFace))
                {


                    //进行数据获取和填充
                    FaceSearchInfo faceSearchInfo=null;
                    yield return StartCoroutine(FaceDetect.instance.SearchDetectAsync(targetFace.base64Data, (info) => {
                        faceSearchInfo = info;
                    }));

                    string faceString="";
                    if (faceSearchInfo != null)
                    {
                        faceString = FaceDetect.instance.GetFaceString(faceSearchInfo);
                    }
                    Debug.Log("faceString:" + faceString);
                    //判定回馈数据是否正确，不正确，则继续入队
                    if (faceString == "")
                    {
                        if (!waitForDateFaces.Contains(targetFace))
                        {
                            waitForDateFaces.Enqueue(targetFace);
                        }
                        targetFace.faceInfo = "正在识别..";
                    }
                    else
                    {
                        targetFace.faceInfo = faceString;
                    }


                }
            }
            yield return new WaitForEndOfFrame();
        }
    }


    public void CheckOutFaces(List<ResultBox> personResultBoxs, Texture2D targetImg)
    {
        List<int> updatedBoxIndex = new List<int>();
        List<FaceInfo> updatedExistFace = new List<FaceInfo>();

        //更新现有的人脸盒子位子信息和图片数据
        for (int i = 0; i < personResultBoxs.Count; i++)
        {
            ResultBox box = personResultBoxs[i];

            for (int j = 0; j < nowFaces.Count; j++)
            {
                FaceInfo face = nowFaces[j];
                if (!updatedExistFace.Contains(face))
                {
                    if (Vector2.Distance(face.resultBox.rect.position, box.rect.position) < maxDisOffset)
                    {
                        updatedBoxIndex.Add(i);
                        updatedExistFace.Add(face);
                        face.resultBox = box;
                        face.base64Data = SliceTexture2DToBase64(targetImg, box.rect);
                        break;
                    }
                }
            }
        }

        //移除旧的丢失的盒子
        nowFaces = updatedExistFace;

        //新增人脸盒子
        for (int i = 0; i < personResultBoxs.Count; i++)
        {
            if (!updatedBoxIndex.Contains(i))
            {
                ResultBox box = personResultBoxs[i];
                string base64data = SliceTexture2DToBase64(targetImg, box.rect);
                FaceInfo face = new FaceInfo(box, base64data);
                nowFaces.Add(face);
                waitForDateFaces.Enqueue(face);
            }
        }

        DrawInfo();
    }



    void DrawInfo()
    {
        Detector.instance.ClearDraw();
        foreach (var item in nowFaces)
        {
            Detector.instance.ShowBox(item.resultBox, null);
            Detector.instance.ShowInfo(item.resultBox, item.faceInfo);
        }
    }


    // 使用Rect参数来截取Texture2D的一部分，转换为字节流，然后转换为Base64字符串
    public string SliceTexture2DToBase64(Texture2D originalTexture, Rect rect)
    {
        // 调整Rect的y坐标，以确保截取的位置正确
        // Unity的Texture2D坐标原点在左下角，但在很多情况下（如UI）我们习惯于以左上角为原点
        rect.y = originalTexture.height - rect.y - rect.height;

        // 确保rect不会超出原始纹理的边界
        rect.x = Mathf.Clamp(rect.x, 0, originalTexture.width);
        rect.y = Mathf.Clamp(rect.y, 0, originalTexture.height);
        rect.width = Mathf.Clamp(rect.width, 0, originalTexture.width - rect.x);
        rect.height = Mathf.Clamp(rect.height, 0, originalTexture.height - rect.y);

        // 创建新的Texture2D，尺寸与截取区域相匹配
        Texture2D newTexture = new Texture2D((int)rect.width, (int)rect.height, originalTexture.format, false);

        // 读取指定区域的像素
        Color[] pixels = originalTexture.GetPixels((int)rect.x, (int)rect.y, (int)rect.width, (int)rect.height);

        // 将读取的像素应用到新Texture2D上
        newTexture.SetPixels(pixels);
        newTexture.Apply();

        // 将新Texture2D转换为字节流，这里以PNG格式为例
        byte[] bytes = newTexture.EncodeToPNG();

        // 销毁临时创建的Texture2D对象
        Destroy(newTexture);

        // 将字节流转换为Base64字符串
        string base64String = Convert.ToBase64String(bytes);

        // 返回Base64字符串
        return base64String;
    }
}



public class FaceInfo
{
    public ResultBox resultBox;
    public string base64Data;
    public string faceInfo;
    //public Texture2D texture2d;


    // 构造函数，接受rectPos、base64Data和key作为参数
    public FaceInfo(ResultBox resultBox, string base64Data)
    {
        this.resultBox = resultBox;
        this.base64Data = base64Data;
        //this.texture2d = texture2d;
    }
}
