using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public TextMeshProUGUI QuestionTxt;

    public void Start()
{
   generateQuestion();
}

 void generateQuestion(){

    currentQuestion = Random.Range(0, QnA.Count);
    QuestionTxt.text = QnA[currentQuestion].Question;
    setAnswer();

    
 }

 void setAnswer(){
     for(int i = 0; i < options.Length; i++){
        options[i].GetComponent<AnswerScript>().isCorrect = false;
        options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

        if(QnA[currentQuestion].CorrectAnswer == i+1){
            options[i].GetComponent<AnswerScript>().isCorrect = true;
         
        }
     }
 }

 public void correct(){
   QnA.RemoveAt(currentQuestion);
   generateQuestion();
  
 }

 public void wrong(){
   QnA.RemoveAt(currentQuestion);
   generateQuestion();
 }
 
}
    


