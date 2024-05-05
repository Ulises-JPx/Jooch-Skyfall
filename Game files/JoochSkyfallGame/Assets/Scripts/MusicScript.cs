/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using UnityEngine;
//Clase que administra los sonidos del juego.
public class MusicPlayer : MonoBehaviour
{
    //Definir variables y referencias a unity
    public AudioClip firstSong;
    public AudioClip secondSong;

    private AudioSource audioSource;
    private bool isPlayingFirstSong = true;

    //Funcion que permite que la musica no se apague aunue se cambien las escenas.
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    //Funcion que inicia la musica
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = firstSong;
        audioSource.Play();
    }
    //Funcion que actualiza la musica para que sea endless
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            if (isPlayingFirstSong)
            {
                audioSource.clip = secondSong;
            }
            else
            {
                audioSource.clip = firstSong;
            }

            audioSource.Play();
            isPlayingFirstSong = !isPlayingFirstSong;
        }
    }
}