using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnswerScript : MonoBehaviour
{

    public bool isCorrect = false;
    public QuizManager quizManager;
    public void Answer(){
        if(isCorrect){

            Debug.Log("Correct Answer");
            quizManager.correct();
            SceneManager.LoadScene("GameScene");

        }else{

            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}
