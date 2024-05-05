/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
//Clase para a funcionalidad del menú principal
public class MainMenu : MonoBehaviour
{
    //Definir variables y referencias a unity
    public GameObject EndingTransition;
    private static float startTime;
    //Función para inicializar los estados de trancisoion del juego
    void Start(){
        EndingTransition.SetActive(false);
    }

    //Función para iniciar el juego
    public void PlayGame()
    {
        startTime = Time.time;  
        StartCoroutine(StartTransitionEnding());
    }
    //Función para salir del juego

    public void QuitGame()
    {
        Application.Quit();
    }

    public static float EndTime()
    {
        return Time.time - startTime;
    }
    //Corrutina para que se muestre el panel de transición
    IEnumerator StartTransitionEnding()
    {
        EndingTransition.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("StoryTellingScene");
    }

    
}
