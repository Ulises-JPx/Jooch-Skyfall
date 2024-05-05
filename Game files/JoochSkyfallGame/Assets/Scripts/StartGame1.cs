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

//Clase para que funione el botón de Start en el menú principal con su audio
public class StartGame1 : MonoBehaviour
{
    public AudioClip clickSound;
    public AudioSource audioSource;

    public void StartGame()
    {   
        audioSource.clip = clickSound;
        audioSource.Play();
        StartCoroutine(WaitForSound());
    }

    IEnumerator WaitForSound(){
        yield return new WaitForSeconds(.3f);
        SceneManager.LoadScene("MenuScene");
    }
}