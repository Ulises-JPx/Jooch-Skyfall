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
//Clase para el sonido de los clicks en todos lo botones del juego
public class ScriptSoundEffectsMenu : MonoBehaviour
{
    public AudioClip clickSound;
    public AudioSource audioSource;

    public void PlayClickSound()
    {
        audioSource.clip = clickSound;
        audioSource.Play();
    }
}
