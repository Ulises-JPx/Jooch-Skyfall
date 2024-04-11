using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PreguntaDisplay : MonoBehaviour{
    [SerializeField] private GameObject StartingTransition;
    
    public static int correctas = 0;
    public static int incorrectas = 0;
    public List<PreguntaSO> preguntas;
    public PreguntaSO preguntaQz;

    public TextMeshProUGUI preguntaTexto;
    public TextMeshProUGUI opc1Texto;
    public TextMeshProUGUI opc2Texto;
    public TextMeshProUGUI opc3Texto;

    
    void Start()
    {
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
        if (preguntaQz.correcta ==1){
            correctas++;
            SceneManager.LoadScene("AdvantageScene");
              
        }else{
            incorrectas++;
            SceneManager.LoadScene("DisadvantageScene");
        }
    }
    public void boton2(){
        if (preguntaQz.correcta ==2){
            correctas++;
            SceneManager.LoadScene("AdvantageScene"); 
        }else{
            incorrectas++;
            SceneManager.LoadScene("DisadvantageScene");
        }
    }
    public void boton3(){
        if (preguntaQz.correcta ==3){
            correctas++;
            SceneManager.LoadScene("AdvantageScene");
        }else{
            incorrectas++;
            SceneManager.LoadScene("DisadvantageScene");
        }
    }

    IEnumerator TurnoffTransition(){
        yield return new WaitForSeconds(3);
        StartingTransition.SetActive(false);
    }

}
