using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class RenderBothCameras : MonoBehaviour
{
    [SerializeField]
    private RawImage[] rawImage;

    private WebCamDevice[] devices;

    private void Start()
    {
        devices = WebCamTexture.devices;

        if(devices.Length > 0)
        {
            DisplayCamera();
        }
    }

    private void DisplayCamera()
    {
        for (int i = 0; i < devices.Length; i++)
        {
            WebCamTexture webCam = new WebCamTexture(devices[0].name);
            rawImage[i].material.mainTexture = webCam;
            webCam.Play();
        }
    }
}
