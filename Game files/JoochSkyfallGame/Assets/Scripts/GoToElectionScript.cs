/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Clase para que funcione el botón de ir a la elección

public class GoToElectionScript : MonoBehaviour
{
    //Definir variables y referencias a unity
    public GameObject TransitionStart;
    public GameObject TransitionEnd;

    //Función para que se muestre la transición de inicio
    void Start()
    {
        TransitionEnd.SetActive(false);
        StartCoroutine(StartTransition());
    }
    //Corrutina para la transición de inicio
    IEnumerator StartTransition()
    {
        TransitionStart.SetActive(true);
        yield return new WaitForSeconds(3);
        TransitionStart.SetActive(false);
    }
    //Función para ir a la elección
    public void GoToElection()
    {
        StartCoroutine(StartEndTransition());
        

    }
    //Corrutina para la transición de fin
    IEnumerator StartEndTransition()
    {
        
        TransitionEnd.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("ElectionScene");
    }
}
