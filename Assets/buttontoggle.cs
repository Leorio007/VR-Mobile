using UnityEngine;
using UnityEngine.UI;

public class ToggleMenu : MonoBehaviour
{
    public GameObject menuPanel;

    public void ToggleMenuPanel()
    {
        menuPanel.SetActive(!menuPanel.activeSelf);
    }
}
