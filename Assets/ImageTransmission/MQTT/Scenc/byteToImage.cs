using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using M2MqttUnity.Examples;

public class byteToImage : MonoBehaviour
{
    public RawImage m_RawImage;
    //texture to receive
    public Texture2D receiveTexture;
    public MQTTTest mqtt;
    public byte[] receiveBytes;
    //public MQTTTest mqtt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        receiveBytes = mqtt.receiveByte;

        receiveTexture.LoadImage(receiveBytes);

        m_RawImage.texture = receiveTexture;
    }
}
