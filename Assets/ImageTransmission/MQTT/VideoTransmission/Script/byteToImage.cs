using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using M2MqttUnity.Examples;

public class byteToImage : MonoBehaviour
{
    public RawImage DepthRawImage, ColorRawImage, HumanRawImage;
    //texture to receive
    public Texture2D DepthreceiveTexture, ColorreceiveTexture, HumanreceiveTexture;
    public MQTTTest mqtt;
    public byte[] DepthReceiveBytes, ColorReceiveBytes, HumanReceiveBytes;
    //public MQTTTest mqtt;
    // Start is called before the first frame update
    void Start()
    {
        DepthreceiveTexture  = new Texture2D(2, 2,TextureFormat.RGBA32,false);
        ColorreceiveTexture = new Texture2D(2, 2, TextureFormat.RGBA32, false);
        HumanreceiveTexture = new Texture2D(2, 2, TextureFormat.RGBA32, false);

        StartCoroutine(waiter());
    }


    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.1f);

        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            DecodeToImage();



        }



    }
    // Update is called once per frame
    void DecodeToImage()
    {
        DepthReceiveBytes = mqtt.DepthImageByte;
        ColorReceiveBytes = mqtt.ColorImageByte;
        HumanReceiveBytes = mqtt.HumanImageByte;

        if(DepthReceiveBytes != null)
        {
            DepthreceiveTexture.LoadImage(DepthReceiveBytes);
        }

        if (ColorReceiveBytes != null)
        {
            ColorreceiveTexture.LoadImage(ColorReceiveBytes);
        }

        if (HumanReceiveBytes != null)
        {
            HumanreceiveTexture.LoadImage(HumanReceiveBytes);
        }


        DepthRawImage.texture = DepthreceiveTexture;
        ColorRawImage.texture = ColorreceiveTexture;
        HumanRawImage.texture = HumanreceiveTexture;
    }
}
