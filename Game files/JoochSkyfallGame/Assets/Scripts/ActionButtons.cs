/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using UnityEngine;
using UnityEngine.UI;
//Clase para que funcionen los botones de acción
public class ActionButtons : MonoBehaviour
{
    //Definir variables y referencias a unity
    public Button RankingButton;
    public Button VolverButton;
    public static string ranking = "https://198.199.66.6/ranking.html";
    public static string refresh = "https://198.199.66.6/game";


    //Función para que los botones hagan lo que se les pide
    void Start()
    {
        VolverButton.onClick.AddListener(RestartGame);
        RankingButton.onClick.AddListener(OpenRanking);
    }

    
    //Función para que se abra el ranking, se llama a la URL del ranking
    void OpenRanking()
    {
        Application.OpenURL(ranking);
    }

    void RestartGame(){
        Application.OpenURL(refresh);
    }
}
