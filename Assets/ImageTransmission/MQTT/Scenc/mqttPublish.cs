using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using M2MqttUnity.Examples;
public class mqttPublish : MonoBehaviour
{
    public MQTTTest mqtt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mqtt.TestPublish();
    }
}
