using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class RenderBothCameras : MonoBehaviour
{
    [SerializeField]
    private RawImage rawImage;
    [SerializeField]
    private Transform parent;

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
            var tex = Instantiate(rawImage, parent);

            WebCamTexture webCam = new WebCamTexture(devices[0].name);
            tex.material.mainTexture = webCam;
            webCam.Play();
        }
    }
}
