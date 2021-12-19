# ar-iot-combo
## Experiment 4: Integrating AR IoT (MQTT enabled AR app)
This experiment includes, for the first time, an MQTT enabled AR application integrated to IoT data. The AR app
was transformed in a true MQTT client, and it is using the subscribe messages to access the MPC variables in
real-time, permitting their visualization inside the AR interface. This way, we have a direct integration between the
AR and IoT environments via MQTT. At this point, the experiment delivers a "read-only" version of the AR app.
No modifications in terms of variables’ values, or even remote commands were implemented.
<br>
<div align=center>
    <img src="https://github.com/paulonegrao/assets/blob/master/POC_EXP4_1.png" height="50%" width="50%" alt="AR - IoT Combo" width="650px" />
</div>
<h3>Proceedings</h3>
<ul>
<li>Components:
    <ul>
        <li>One 3D Printer (thiNgator): running Marlin</li>
        <li>One Raspberry Pi: running Mosquitto, OctoPrint, and Node-RED</li>
        <li>One IPhone: running the Unity Vuforia AR app</li>
    </ul>
<li>Tasks (only the additional ones will be listed):</li>
    <ul>
        <li>Install and configure Unity and Vuforia free versions for XR/AR development (to develop AR apps).</li>
        <li>Install and configure M2MQTT open-source library (to enable AR via MQTT apps using subscribe
messages)</li>
     </ul>
</ul>
<h3>Results</h3>
After implementing the required proceedings, the AR app was able to connect to the IoT environment via MQTT,
acting as a client, and using subscribe messages. This way, the AR app has correctly accessed and displayed
(read-only) the Nozzle Extruder and Bed temperature values in real-time, reflecting all eventual temperature
fluctuations occurred to the variables inside the IoT environment,.
<br>
<div align=center>
    <img src="https://github.com/paulonegrao/assets/blob/master/POC15.png" height="50%" width="50%" alt="AR - IoT Combo" width="650px" />
</div>
<br>
<div align=center>
    <img src="https://github.com/paulonegrao/assets/blob/master/POC16.png" height="50%" width="50%" alt="AR - IoT Combo" width="650px" />
</div>
