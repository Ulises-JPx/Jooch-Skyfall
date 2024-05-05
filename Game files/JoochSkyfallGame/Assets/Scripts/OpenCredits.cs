/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using UnityEngine;
using UnityEngine.UI;
//Clase para que se abran los créditos del juego
public class OpenCredits : MonoBehaviour
{
    public Button CreditosButton;
    public static string creditos = "https://198.199.66.6/creditos.html";

    void Start()
    {
        CreditosButton.onClick.AddListener(OpenCreditos);
    }

    void OpenCreditos()
    {
        Application.OpenURL(creditos);
    }
}