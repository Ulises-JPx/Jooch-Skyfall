using UnityEngine;
using UnityEngine.UI;

public class OpenWebPage : MonoBehaviour
{
    public Button yourButton; // Asegúrate de asignar este botón en el Inspector de Unity
    public static string url = "http://127.0.0.1:5500/WebDev/credits/index.html";

    void Start()
    {
        yourButton.onClick.AddListener(OpenURL);
    }

    void OpenURL()
    {
        Application.OpenURL(url);
    }
}