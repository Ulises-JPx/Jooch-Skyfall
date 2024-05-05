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
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

//Clase para las preguntas del quiz
public class PreguntaDisplay : MonoBehaviour{
    //Variables para el quiz y referencias a elementos utilizdos en unity
    public GameObject CorrectCHoice;
    public GameObject IncorrectChoice;
    public AudioSource correctSource;
    public AudioSource incorrectSource;
    public AudioClip correctSound;
    public AudioClip incorrectSound;
    [SerializeField] private GameObject StartingTransition;
    [SerializeField] private GameObject CorrectEndingTransition;

    [SerializeField] private GameObject IncorrectEndingTransition;
    
    public static int correctas = 0;
    public static int incorrectas = 0;
    public static List<PreguntaSO> preguntas;
    public static PreguntaSO preguntaQz;

    public TextMeshProUGUI preguntaTexto;
    public TextMeshProUGUI opc1Texto;
    public TextMeshProUGUI opc2Texto;
    public TextMeshProUGUI opc3Texto;
    public TextMeshProUGUI textoCorrectas;
    public TextMeshProUGUI textoIncorrectas;

    private int contadorPreguntas = 0; // Nuevo contador de preguntas
    private const int limitePreguntas = 3; // Límite de preguntas por ronda
    public static bool triviaCheker;

    //Funcion ue inicializa la escena para el quiz
    void Start()
    {
        CorrectCHoice.SetActive(false);
        IncorrectChoice.SetActive(false);
        CorrectEndingTransition.SetActive(false);
        IncorrectEndingTransition.SetActive(false);
        preguntas = new List<PreguntaSO>(Resources.LoadAll<PreguntaSO>("Preguntas"));
        correctSource.clip = correctSound;
        incorrectSource.clip = incorrectSound;
        StartCoroutine(TurnoffTransition());
        generateQuestion();
    }
    //Funcion para generar las preguntas del quiz
    public void generateQuestion(){
        preguntaQz = preguntas[Random.Range(0, preguntas.Count)];

        preguntaTexto.text = preguntaQz.SO_Pregunta;
        opc1Texto.text = preguntaQz.SO_Op1;
        opc2Texto.text = preguntaQz.SO_Op2;
        opc3Texto.text = preguntaQz.SO_Op3;

    }
    //Funciones para los botones de las opciones correcta e incorrecta
    //Se suma la cantidad de respuestas correctas e incorrectas
    //Se actualiza el texto de las respuestas correctas e incorrectas
    //Se verifica si se llego al limite de preguntas
    public void boton1(){
        if (preguntaQz.SO_Correcta == 1){
            correctas++;
            triviaCheker = true;
            textoCorrectas.text = correctas.ToString(); // Actualiza el texto
            correctSource.Play();
            StartCoroutine(StartCorrectChoiceAnimAndTurnOff());
        }else{
            incorrectas++;
            triviaCheker = false;
            textoIncorrectas.text = incorrectas.ToString(); // Actualiza el texto
            incorrectSource.Play();
            StartCoroutine(StartIncorrectChoiceAnimAndTurnOff());
        }
        verificarPreguntas();
    }
    public void boton2(){
        if (preguntaQz.SO_Correcta == 2){
            correctas++;
            triviaCheker = true;
            textoCorrectas.text = correctas.ToString(); // Actualiza el texto
            correctSource.Play();
            StartCoroutine(StartCorrectChoiceAnimAndTurnOff());
        }else{
            incorrectas++;
            triviaCheker = false;
            textoIncorrectas.text = incorrectas.ToString(); // Actualiza el texto
            incorrectSource.Play();
            StartCoroutine(StartIncorrectChoiceAnimAndTurnOff());
        }
        verificarPreguntas();
    }
    public void boton3(){
        if (preguntaQz.SO_Correcta == 3){
            correctas++;
            triviaCheker = true;
            textoCorrectas.text = correctas.ToString(); // Actualiza el texto
            correctSource.Play();
            StartCoroutine(StartCorrectChoiceAnimAndTurnOff());
        }else{
            incorrectas++;
            triviaCheker = false;
            textoIncorrectas.text = incorrectas.ToString(); // Actualiza el texto
            incorrectSource.Play();
            StartCoroutine(StartIncorrectChoiceAnimAndTurnOff());
        }
        verificarPreguntas();
    }
    //Funcion para verificar si se llego al limite de preguntas
    private void verificarPreguntas() {
        contadorPreguntas++;
        int id_pregunta = preguntaQz.SO_Id;
        int resultado = triviaCheker ? 1 : 0;
        DataSaver.Trivia(id_pregunta, resultado);
        if (contadorPreguntas >= limitePreguntas) {
            if (correctas >= 2) {
                StartCoroutine(StartandTurnOffCorrectTransition());
            } else {
                StartCoroutine(StartandTurnOffIncorrectTransition());
            }
            correctas = 0;
            incorrectas = 0;
        } else {
            generateQuestion();
            ResetButtonStates();
        }
    }
    //Funcion para resetear los botones y su estado
    private void ResetButtonStates()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    //Corrutinas para las transiciones de la escena
    IEnumerator TurnoffTransition(){
        yield return new WaitForSeconds(3);
        StartingTransition.SetActive(false);
    }

    IEnumerator StartandTurnOffCorrectTransition(){
        CorrectEndingTransition.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("AdvantageScene");
    }
    IEnumerator StartandTurnOffIncorrectTransition(){
        IncorrectEndingTransition.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("DisadvantageScene");
    }
    IEnumerator StartCorrectChoiceAnimAndTurnOff(){
        CorrectCHoice.SetActive(true);
        yield return new WaitForSeconds(1);
        CorrectCHoice.SetActive(false);
    }
    IEnumerator StartIncorrectChoiceAnimAndTurnOff(){
        IncorrectChoice.SetActive(true);
        yield return new WaitForSeconds(1);
        IncorrectChoice.SetActive(false);
    }

}