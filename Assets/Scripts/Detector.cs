using Assets.Scripts;
using Assets.Scripts.TextureProviders;
using NN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Unity.Barracuda;
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEditor.VersionControl.Message;
using static UnityEngine.Networking.UnityWebRequest;
using Image = UnityEngine.UI.Image;

public class Detector : MonoBehaviour
{
    public static Detector instance;

    public Text fpsText;
    //用于渲染真相机无损画面
    public RawImage realCameraImage;

    [Tooltip("yolo模型")]
    public NNModel ModelFile;

    //用于渲染可ai处理的相机画面，640*640
    public RawImage yoloCameraImage;


    //ai相机的遮罩
    public RectTransform yoloCameraImageMask;

    [Range(0.0f, 1f)]
    [Tooltip("方框置信度的最小值，低于此值的方框将不会被绘制")]
    public float MinBoxConfidence = 0.3f;

    [SerializeField]
    protected TextureProviderType.ProviderType textureProviderType;

    [SerializeReference]
    protected TextureProvider textureProvider = null;

    //神经网络句炳，存放模型和worker
    protected NNHandler nn;


    //yolo处理器
    YOLOv8 yolo;


    //贞率变量
    float deltaTime;


    //用于统一管理yolo显示文本的链表
    private List<GameObject> allInfoShow = new List<GameObject>();


    private void Start()
    {
        instance = this;
    }

    private void OnEnable()
    {
        //初始化yolo
        nn = new NNHandler(ModelFile);
        yolo = new YOLOv8Segmentation(nn);

        //初始化画面提供器，相机画面由textureProvider生成
        textureProvider = GetTextureProvider(nn.model);
        textureProvider.Start();
    }


    protected void ReleaseTexture()
    {
        if (TextureTools.resultTexture != null)
        {
            Destroy(TextureTools.resultTexture);
        }
    }

    private void Update()
    {
        ReleaseTexture();

        YOLOv8OutputReader.DiscardThreshold = MinBoxConfidence;
        Texture2D texture = textureProvider.GetTexture(yoloCameraImageMask);
        var boxes = yolo.Run(texture);

        List<ResultBox> personBox = new List<ResultBox>();
        foreach (var item in boxes)
        {
            if (item.bestClassIndex == 0) personBox.Add(item);
        }
        FaceManager.instance.CheckOutFaces(personBox, texture);

        yoloCameraImage.texture = texture;
        //DrawResults(boxes, texture);


        // cameraImage.texture = textureProvider.GetOringnalTexture();

        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        fpsText.text = string.Format("{0:0.} fps", fps);
    }


    //初始化画面提供器
    protected TextureProvider GetTextureProvider(Model model)
    {
        var firstInput = model.inputs[0];
        int height = firstInput.shape[5];
        int width = firstInput.shape[6];
        yoloCameraImage.rectTransform.sizeDelta = new Vector2(width, height);
        TextureProvider provider;
        switch (textureProviderType)
        {
            case TextureProviderType.ProviderType.WebCam:
                provider = new WebCamTextureProvider(textureProvider as WebCamTextureProvider, width, height);
                break;

            case TextureProviderType.ProviderType.Video:
                provider = new VideoTextureProvider(textureProvider as VideoTextureProvider, width, height);
                break;
            default:
                throw new InvalidEnumArgumentException();
        }
        return provider;
    }


    void OnDisable()
    {
        //释放神经网络资源
        nn.Dispose();
        //停止画面渲染
        textureProvider.Stop();
    }


    public void ClearDraw()
    {
        foreach (var item in allInfoShow)
        {
            GameObjectPoolTool.PutInPool(item);
        }
    }

    //绘制检测框和文本
    protected void DrawResults(IEnumerable<ResultBox> results, Texture2D img)
    {
        ClearDraw();
        results.ForEach(box =>
        {
            ShowBox(box, img);
            ShowInfo(box, " " + YoloConfig.names[box.bestClassIndex] + "(" + (box.score * 100).ToString("0.0") + "%)");
        });
    }



    //单一检测绘制
    public virtual void ShowBox(ResultBox box, Texture2D img, int width = 1)
    {
        //TextureTools.DrawRectOutline(img, box.rect, boxColor, 1, rectIsNormalized: false, revertY: true);

        Color color = GetColorForPercentage(box.score);
        Vector3 leftUpLocalPos = new Vector2(box.rect.x - yoloCameraImage.rectTransform.sizeDelta.x / 2, yoloCameraImage.rectTransform.sizeDelta.y / 2 - box.rect.y);
        GameObject infoShow = GameObjectPoolTool.GetFromPool("", "Box", leftUpLocalPos, yoloCameraImage.transform, true);

        // 获取 Image 组件
        Image imageComponent = infoShow.GetComponent<Image>();
        imageComponent.color = new Color(color.r, color.g, color.b, imageComponent.color.a);

        // 设置 Image 的大小和位置
        imageComponent.rectTransform.sizeDelta = box.rect.size * yoloCameraImageMask.localScale.x;

        if (!allInfoShow.Contains(infoShow))
        {
            allInfoShow.Add(infoShow);
        }
    }








    public virtual void ShowInfo(ResultBox box, string info)
    {
        Color color = GetColorForPercentage(box.score);
        Vector3 leftUpLocalPos = new Vector2(box.rect.x - yoloCameraImage.rectTransform.sizeDelta.x / 2, yoloCameraImage.rectTransform.sizeDelta.y / 2 - box.rect.y);

        GameObject infoShow = GameObjectPoolTool.GetFromPool("", "InfoShow", leftUpLocalPos, yoloCameraImage.transform, true);
        Text infoText = infoShow.GetComponentInChildren<Text>();

        infoText.text = info;
        infoText.color = color;

        // 设置 text 的大小和位置
        infoShow.transform.GetComponent<RectTransform>().sizeDelta = box.rect.size * yoloCameraImageMask.localScale.x;
        if (!allInfoShow.Contains(infoShow))
        {
            allInfoShow.Add(infoShow);
        }
    }


    //防止运行时手动编辑？？
    private void OnValidate()
    {
        Type t = TextureProviderType.GetProviderType(textureProviderType);
        if (textureProvider == null || t != textureProvider.GetType())
        {
            if (nn == null)
                // textureProvider = RuntimeHelpers.GetUninitializedObject(t) as TextureProvider;
                textureProvider = Activator.CreateInstance(t) as TextureProvider;
            //textureProvider = Activator.CreateInstance<TextureProvider>();
            else
            {
                textureProvider = GetTextureProvider(nn.model);
                textureProvider.Start();
            }

        }
    }

    /// <summary>
    /// 根据百分比参数获取对应的颜色。
    /// </summary>
    /// <param name="percentage">百分比参数，取值范围为0到1。</param>
    /// <returns>返回对应的颜色。</returns>
    protected Color GetColorForPercentage(float percentage)
    {
        if (percentage >= 0.85f && percentage <= 1f)
        {
            return Color.green; // 返回绿色
        }
        else if (percentage >= 0.70f && percentage < 0.85f)
        {
            return Color.cyan; // 返回青色
        }
        else if (percentage >= 0.50f && percentage < 0.70f)
        {
            return Color.yellow;  // 返回黄色
        }
        else if (percentage >= 0.30f && percentage < 0.50f)
        {
            return Color.magenta;// 百分比在0.65到0.75之间，返回品红色
        }
        else
        {
            return Color.red; //返回红色
        }

    }

}
