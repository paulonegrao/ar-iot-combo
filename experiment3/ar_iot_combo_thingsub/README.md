# ar-iot-combo
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
