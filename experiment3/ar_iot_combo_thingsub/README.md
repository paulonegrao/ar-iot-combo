# ar-iot-combo
## Experiment 3
This experiment includes, for the first time, an AR application integrated to IoT data. In this case, we will be using
a cloud dataset as an intermediary stage between the IoT environment and the AR app. The Node-RED code will
be monitoring the MPC variables via MQTT. When the temperature values present a variation equal or greater a
previously configured threshold (in this case, set to +/- 0.1 °C), these values will be immediately updated in an
Airtable component (a cloud dataset, commonly used in IoT integrations). Simultaneously, an AR application using
Vuforia Toolbox will be continuously reading the cloud dataset and presenting the temperature values in a counter
and in a graph component, which are being displayed inside the AR app.
<br>
<div align=center>
    <img src="https://github.com/paulonegrao/assets/blob/master/POC13.png" height="50%" width="50%" alt="AR - IoT Combo" width="650px" />
</div>
### Proceedings
• Components:
– One 3D Printer (thiNgator): running Marlin
– One Raspberry Pi: running Mosquitto, OctoPrint, and Node-RED
– One Raspberry Pi: running Node-RED, Vuforia Spatial Edge Server
– One IPhone: running the Vuforia Toolbox app
• Tasks (only the additional ones will be listed):
– Install and configure Vuforia Spatial Edge Server open-source distributed edge infrastructure (to connect
the Vuforia Toolbox app to physical objects, machines, and processes).
– Configure Airtable free version (platform for building collaborative apps in the cloud).
– Install and configure Vuforia Toolbox open-source AR app (to enable visualization and interaction with
data and logic provided by the Vuforia Spatial Edge Server).
*Results
After implementing the required proceedings, the Node-RED has correctly updated the Airtable intermediary cloud
dataset. In the sequence, the AR Vuforia Toolbox application has correctly accessed the cloud dataset and displayed
the Nozzle Extruder temperature value in real-time, reflecting all eventual temperature fluctuations occurred to the
variable inside the IoT environment.
<br>
<div align=center>
    <img src="https://github.com/paulonegrao/assets/blob/master/POC14.png" height="50%" width="50%" alt="AR - IoT Combo" width="650px" />
</div>
