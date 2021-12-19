
using UnityEngine;

[System.Serializable]
public class SensorData 
{
    // public float temperature=0f;
    // public float humidity=0f;
    // thiNgCode: JSON from 3D Printer  {"actual": 200.56, "target": 200.0, "_timestamp": 1636044691}
    public float actual=0f;

    public static SensorData CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<SensorData>(jsonString);
    }
}
