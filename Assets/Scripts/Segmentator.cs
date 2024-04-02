using NN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Segmentator : Detector
    {
        YOLOv8Segmentation yolo;

        // Use this for initialization
        void OnEnable()
        {
            nn = new NNHandler(ModelFile);
            yolo = new YOLOv8Segmentation(nn);

            textureProvider = GetTextureProvider(nn.model);
            textureProvider.Start();
        }

        // Update is called once per frame
        void Update()
        {
            ReleaseTexture();
            YOLOv8OutputReader.DiscardThreshold = MinBoxConfidence;
            Texture2D texture = textureProvider.GetTexture();      
            List<ResultBoxWithMask> boxes = yolo.Run(texture);
            DrawResults(boxes, texture);
            yoloCameraImage.texture = texture;
        }

        void OnDisable()
        {
            nn.Dispose(); 
            textureProvider.Stop();
        }

        public override void ShowBox(ResultBox box, Texture2D img, int width = 1)
        {
            base.ShowBox(box, img);

            ResultBoxWithMask boxWithMask = box as ResultBoxWithMask;
            Color boxColor = GetColorForPercentage(box.score);
            TextureTools.RenderMaskOnTexture(boxWithMask.masks, img, boxColor);
            boxWithMask.masks.tensorOnDevice.Dispose();
        }
    }
}