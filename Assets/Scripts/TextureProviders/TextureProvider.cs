using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Video;

namespace Assets.Scripts.TextureProviders
{
    [Serializable]
    public abstract class TextureProvider
    {
        //输出的画面
        protected Texture2D ResultTexture;

        //输入进来的画面
        protected Texture InputTexture;

        public TextureProvider(int width, int height, TextureFormat format = TextureFormat.RGB24)
        {
            ResultTexture = new Texture2D(width, height, format, mipChain: false);
        }

        public TextureProvider() { }

        ~TextureProvider()
        {
            Stop();
        }

        public abstract void Start();

        public abstract void Stop();



        public virtual Texture2D GetTexture(RectTransform yoloMask = null)
        {
            //剪输入的画面转成texture2d，返回结果（此处要保证画面分辨率一致）


            Texture targetTexture = TextureTools.ForceSquareAndFill(InputTexture, ResultTexture,yoloMask);

            return TextureTools.ResizeAndCropToCenter(targetTexture, ref ResultTexture, ResultTexture.width, ResultTexture.height);

        }

        public virtual Texture GetOringnalTexture()
        {
            return InputTexture;
        }

        public abstract TextureProviderType.ProviderType TypeEnum();
    }


    public static class TextureProviderType
    {
        static TextureProvider[] providers;

        // 假设你定义了这样一个委托
        delegate TextureProvider ProviderFactory();

        static TextureProviderType()
        {
            //providers = new TextureProvider[]{
            //    RuntimeHelpers.GetUninitializedObject(typeof(WebCamTextureProvider)) as WebCamTextureProvider,
            //    RuntimeHelpers.GetUninitializedObject(typeof(VideoTextureProvider)) as VideoTextureProvider };

            providers = new TextureProvider[]{
               Activator.CreateInstance<WebCamTextureProvider>(),
               Activator.CreateInstance<VideoTextureProvider>()};

        }



        public enum ProviderType
        {
            WebCam,
            Video
        }

        static public Type GetProviderType(ProviderType type)
        {
            foreach (var provider in providers)
            {
                if (provider.TypeEnum() == type)
                    return provider.GetType();
            }
            throw new InvalidEnumArgumentException();
        }
    }
}