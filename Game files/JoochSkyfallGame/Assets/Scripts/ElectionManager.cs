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
//Clase que administra la elección de financiamiento y sus valores que se utilizarán en el juego.
public class ElectionManager : MonoBehaviour
{
    //Definir variables y referencias a unity
    public GameObject EndingTransition;
    public GameObject StartingTransition;
    public static float deuda = 0;
    public static float interes = 0;

    public static int TipoFinanciamiento;
    //Función para inicializar los estados de trancisoion del juego
    public void Start(){
        EndingTransition.SetActive(false);
        StartingTransition.SetActive(true);
        StartCoroutine(TurnOffStartTransition());
    }
    //Función para iniciar el juego con el financiamiento de Verqor
    public void playGameOnVerqor(){
        StartCoroutine(UpdatePlayer.GeneratePlayerPartida());
        TipoFinanciamiento = 1;
        deuda = 16500;
        interes = 10f;
        ItemManager.verCoinsCount = 15000;
        StartCoroutine(StartTransitionEnding());
        // Debug.Log("Verqor" + deuda + interes);


    }
    //Función para iniciar el juego con el financiamiento de Coyote
    public void playGameOnCoyote(){
        StartCoroutine(UpdatePlayer.GeneratePlayerPartida());
        TipoFinanciamiento = 2; 
        deuda = 23000;
        interes = 15f;
        ItemManager.verCoinsCount = 20000;
        StartCoroutine(StartTransitionEnding());
        // Debug.Log("Coyote" + deuda + interes);

    }
    //Función para iniciar el juego con el financiamiento de Banco
    public void playGameOnBanco(){
        StartCoroutine(UpdatePlayer.GeneratePlayerPartida());
        TipoFinanciamiento = 3;
        deuda = 28000;
        interes = 12f;
        ItemManager.verCoinsCount = 25000;
        StartCoroutine(StartTransitionEnding());
        // Debug.Log("Banco" + deuda + interes);

    }
    //Corrutina para que se muestre el panel de transición

    IEnumerator StartTransitionEnding()
    {
        EndingTransition.SetActive(true);
        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene("GameScene");
    }

    IEnumerator TurnOffStartTransition(){
        yield return new WaitForSeconds(1.5f);
        StartingTransition.SetActive(false);
    }
}
