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
        }else

        {
            debugText.text = devices.Length.ToString();
        }
    }
}
