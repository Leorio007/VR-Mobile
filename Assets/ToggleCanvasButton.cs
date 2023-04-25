using UnityEngine;
using UnityEngine.UI;

public class ToggleCanvasScript : MonoBehaviour
{
    public Canvas canvas;

    public void ToggleCanvas()
    {
        canvas.enabled = !canvas.enabled;
    }
}
