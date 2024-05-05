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
//Clase para que se muestre el botón de jugar de nuevo después de ganar o perder
public class PlayAgainWinOrLose : MonoBehaviour
{
    //Definir variables y referencias a unity
    public GameObject PlayAgain;
    // Start is called before the first frame update
    //Función para que se muestre el botón de jugar de nuevo después de ganar o perder
    void Start()
    {
        PlayAgain.SetActive(false);
        StartCoroutine(PlayAgainFun());
    }
    //Corutina para que se muestre el botón de jugar de nuevo después de ganar o perder
    IEnumerator PlayAgainFun()
    {
        yield return new WaitForSeconds(2);
        PlayAgain.SetActive(true);
    }

    public void RestartGame(){
        //Aqui ponemos un reset del juego

    }

    
}
