using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElectionManager : MonoBehaviour
{
    public static float deuda = 0;
    public static float interes = 0;

    public static int TipoFinanciamiento;

    public void playGameOnVerqor(){

        TipoFinanciamiento = 1;
        deuda = 7000;
        interes = 20f;
        SceneManager.LoadScene("GameScene");
        Debug.Log("Verqor" + deuda + interes);


    }
    public void playGameOnCoyote(){

        TipoFinanciamiento = 2; 
        deuda = 10000;
        interes = 40f;
        SceneManager.LoadScene("GameScene");
        Debug.Log("Coyote" + deuda + interes);

    }
    public void playGameOnBanco(){

        TipoFinanciamiento = 3;
        deuda = 8000;
        interes = 25f;
        SceneManager.LoadScene("GameScene");
        Debug.Log("Banco" + deuda + interes);

    }
}
