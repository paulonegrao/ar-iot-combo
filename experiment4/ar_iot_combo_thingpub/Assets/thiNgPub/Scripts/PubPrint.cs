using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using System.Net;
using System;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;


public class PubPrint : MonoBehaviour
{

    private MqttClient client;

    public string brokerAddress;

    // thiNgCode: set MQTT topic tto print thiNg
    private string topic1 = "AR_IoT_combo/thiNg/print_thiNg";


    public void PrintStart()
    {
        Debug.Log(">>>> PreheatStart");
        // thiNgCode: set MQTT Broker address & port
        client = new MqttClient(brokerAddress,1883 , false , null ); 
		
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 
        
        client.Publish(topic1, System.Text.Encoding.UTF8.GetBytes("thiNg print thiNg, roger..."), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false); 

    }
}
