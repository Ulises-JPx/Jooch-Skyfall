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
using UnityEngine.Audio;
//Clase para que funcione el botón de Settings en el menú principal con su audio
public class SettingsMenu : MonoBehaviour
{
    //Definir variables y referencias a unity
    public AudioMixer audioMixer;
    public AudioMixer audioMixerSfx;

    //Función para cambiar el volumen de la música
    public void SetVolume (float volume){
        audioMixer.SetFloat("MusicaVolumen", volume);
    }
    //Función para cambiar el volumen de los efectos de sonido
    public void SetVolumeSfx (float volumeSfx){
        audioMixerSfx.SetFloat("SoundEffect", volumeSfx);
    }
    //Función para activar o desactivar el sonido

    public void SoundOnOff(bool sound){
        if (sound){
            audioMixer.SetFloat("MusicaVolumen", 0);
            audioMixerSfx.SetFloat("SoundEffect", 0);
        }else{
            audioMixer.SetFloat("MusicaVolumen", -80);
            audioMixerSfx.SetFloat("SoundEffect", -80);
        }

    }
}
