using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class RenderBothCameras : MonoBehaviour
{
    [SerializeField]
    private RawImage frontCamera;
    [SerializeField]
    private RawImage backCamera;
    [SerializeField]
    private TextMeshProUGUI debugText;

    private void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        if(devices.Length == 0)
        {
            debugText.text = "No devices found";
        }

        // for debugging purposes, prints available devices to the console
        for (int i = 0; i < devices.Length; i++)
        {
            Debug.Log("Webcam available: " + devices[i].name);
            debugText.text = "Webcam Available " + devices[i].name;
        }
    }
}
