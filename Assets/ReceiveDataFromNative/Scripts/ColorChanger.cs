using UnityEngine.UI;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField]
    private RawImage Image;

    private void SetColor(string color)
    {
        if (color == "red")
            Image.material.color = Color.red;
        else if (color == "blue") Image.material.color = Color.blue;
        else if (color == "green") Image.material.color = Color.green;
        else Image.material.color = Color.white;
    }
}
