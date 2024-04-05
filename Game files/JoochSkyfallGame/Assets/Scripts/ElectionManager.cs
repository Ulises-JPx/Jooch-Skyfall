using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElectionManager : MonoBehaviour
{
    public static float deuda = 0;
    public static float interes = 0;

    public void playGameOnVerqor(){

        deuda = 7000;
        interes = 0.1f;
        SceneManager.LoadScene("GameScene");
        Debug.Log("Verqor" + deuda + interes);


    }
    public void playGameOnCoyote(){
        deuda = 10000;
        interes = 0.4f;
        SceneManager.LoadScene("GameScene");
        Debug.Log("Coyote" + deuda + interes);

    }
    public void playGameOnBanco(){
        deuda = 8000;
        interes = 0.2f;
        SceneManager.LoadScene("GameScene");
        Debug.Log("Banco" + deuda + interes);

    }
}
