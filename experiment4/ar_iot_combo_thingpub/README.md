# ar-iot-combo
## Experiment 4: Integrating AR & IoT (full interaction - read & write support)
This experiment includes, for the first time, an MQTT enabled AR application with full integration to IoT data.
The AR app was transformed in a true MQTT client, and it is using the publish messages to send commands to
the IoT environment and modify the MPC variables in real-time, using virtual buttons inside the AR interface. This
way, we have a direct integration between the AR - IoT environments, via MQTT, and with full control (enabled to
read and write IoT variables). At this point, the AR app has implemented the following buttons/commands:
<ul>
    <li>Preheat - to initiate a 3D printer preheating routine for both, Nozzle Extruder and Bed temperature</li>
    <li>Cooldown - to bring the Nozzle Extruder and Bed components to ambient room temperature</li>
    <li>Print - to send a file (in this case, the thiNg file) to be 3D printed</li>
</ul>
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
        <li>Install and configure M2MQTT open-source library (to enable AR via MQTT apps using publish messages)</li>
messages)</li>
     </ul>
</ul>
<h3>Results</h3>
After implementing the required proceedings, the AR app was able to connect to the IoT environment via MQTT,
acting as a client, and using publish messages. This way, the AR app has commanded Preheat, Cooldown, and
Print routines straight to the MPC 3D printer, inside the IoT environment. The 3D printer has correctly received
the command and started the respective routine with success.
<br><br>
<div align=center>
    <img src="https://github.com/paulonegrao/assets/blob/master/POC15.png" height="50%" width="50%" alt="AR - IoT Combo" width="650px" />
</div>
<br>
<div align=center>
    <img src="https://github.com/paulonegrao/assets/blob/master/POC16.png" height="50%" width="50%" alt="AR - IoT Combo" width="650px" />
</div>
