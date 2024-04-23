using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PreguntaDisplay : MonoBehaviour{
    [SerializeField] private GameObject StartingTransition;
    [SerializeField] private GameObject CorrectEndingTransition;
    
    public static int correctas = 0;
    public static int incorrectas = 0;
    public List<PreguntaSO> preguntas;
    public PreguntaSO preguntaQz;

    public TextMeshProUGUI preguntaTexto;
    public TextMeshProUGUI opc1Texto;
    public TextMeshProUGUI opc2Texto;
    public TextMeshProUGUI opc3Texto;
    public TextMeshProUGUI textoCorrectas;
    public TextMeshProUGUI textoIncorrectas;

    private int contadorPreguntas = 0; // Nuevo contador de preguntas
    private const int limitePreguntas = 3; // Límite de preguntas por ronda

    void Start()
    {
        preguntas = new List<PreguntaSO>(Resources.LoadAll<PreguntaSO>("Preguntas"));
        StartCoroutine(TurnoffTransition());
        generateQuestion();
    }
    
    public void generateQuestion(){
        preguntaQz = preguntas[Random.Range(0, preguntas.Count)];
        
        preguntaTexto.text = preguntaQz.pregunta;
        opc1Texto.text = preguntaQz.opc1;
        opc2Texto.text = preguntaQz.opc2;
        opc3Texto.text = preguntaQz.opc3;

    }
    public void boton1(){
        if (preguntaQz.correcta == 1){
            correctas++;
            Debug.Log("Correcta");
            textoCorrectas.text = correctas.ToString(); // Actualiza el texto
        }else{
            incorrectas++;
            Debug.Log("Incorrecta");
            textoIncorrectas.text = incorrectas.ToString(); // Actualiza el texto
        }
        verificarPreguntas();
    }
    public void boton2(){
        if (preguntaQz.correcta == 2){
            correctas++;
            Debug.Log("Correcta");
            textoCorrectas.text = correctas.ToString(); // Actualiza el texto
        }else{
            incorrectas++;
            Debug.Log("Incorrecta");
            textoIncorrectas.text = incorrectas.ToString(); // Actualiza el texto
        }
        verificarPreguntas();
    }
    public void boton3(){
        if (preguntaQz.correcta == 3){
            correctas++;
            Debug.Log("Correcta");
            textoCorrectas.text = correctas.ToString(); // Actualiza el texto
        }else{
            incorrectas++;
            Debug.Log("Incorrecta");
            textoIncorrectas.text = incorrectas.ToString(); // Actualiza el texto
        }
        verificarPreguntas();
    }

    private void verificarPreguntas() {
        contadorPreguntas++;
        Debug.Log("Correctas: " + correctas + "\nIncorrcetas: " + incorrectas);
        if (contadorPreguntas >= limitePreguntas) {
            if (correctas >= 2) {
                StartCoroutine(StartandTurnOffCorrectTransition());
            } else {
                SceneManager.LoadScene("DisadvantageScene");
            }
        } else {
            generateQuestion();
            ResetButtonStates();
        }
    }
    private void ResetButtonStates()
    {
        EventSystem.current.SetSelectedGameObject(null);
    }

    IEnumerator TurnoffTransition(){
        yield return new WaitForSeconds(3);
        StartingTransition.SetActive(false);
    }

    IEnumerator StartandTurnOffCorrectTransition(){
        CorrectEndingTransition.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("AdvantageScene");
    }

}