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


public class PubCooldown : MonoBehaviour
{

    private MqttClient client;

    public string brokerAddress;

    // thiNgCode: set MQTT topic tool0 = 3D Printer Nozzle Extruder Temperature in C
    private string topic1 = "AR_IoT_combo/thiNg/cooldownTool0";
    // thiNgCode: set MQTT topic bed = 3D Printer Bed Temperature in C
    private string topic2 = "AR_IoT_combo/thiNg/cooldownBed";

    public void CooldownStart()
    {
        Debug.Log(">>>> CooldownStart");
        // thiNgCode: set MQTT Broker address & port
        client = new MqttClient(brokerAddress,1883 , false , null ); 
		
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 
        
        client.Publish(topic1, System.Text.Encoding.UTF8.GetBytes("thiNg cooldown tool0, roger..."), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false); 
    
        client.Publish(topic2, System.Text.Encoding.UTF8.GetBytes("thiNg cooldown bed, roger..."), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false); 
 
    }
}
