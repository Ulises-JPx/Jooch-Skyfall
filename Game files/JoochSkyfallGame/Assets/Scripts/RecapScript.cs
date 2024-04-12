using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using System;
public class RecapScript : MonoBehaviour
{
    public static float calculoVercoins;
    public static int numCiclo = 1;
    public TextMeshProUGUI cicloText;
    public static float precioMaiz = 20;
    public TextMeshProUGUI precioMaizText;
    public static float precioChile = 21;
    public TextMeshProUGUI precioChileText;
    public static float precioJitomate = 22;
    public TextMeshProUGUI precioJitomateText;
    public static float precioAguacate = 23;
    public TextMeshProUGUI precioAguacateText;
    public static float precioCafe = 24;
    public TextMeshProUGUI precioCafeText;
    public TextMeshProUGUI verCoinsCount;
    public TextMeshProUGUI deuda;
    // Start is called before the first frame update
    void Start()
    {
        CalculoVercoins();
        resetCounts();
    }

    // Update is called once per frame
    void Update()
    {
        cicloText.text = "Ciclo: " + numCiclo;
        precioMaizText.text = "$" + Math.Round(precioMaiz, 2);
        precioChileText.text = "$ " + Math.Round(precioChile, 2);
        precioJitomateText.text = "$ " + Math.Round(precioJitomate, 2);
        precioAguacateText.text = "$ " + Math.Round(precioAguacate, 2);
        precioCafeText.text = "$ " + Math.Round(precioCafe, 2);
        verCoinsCount.text = "$" + ItemManager.verCoinsCount;
        deuda.text = "$" + ElectionManager.deuda;
    }

    public void CalculoVercoins(){
        float cuentaMaiz = ItemManager.maizCount * precioMaiz;
        float cuentaChile = ItemManager.chileCount * precioChile;
        float cuentaJitomate = ItemManager.jitomateCount * precioJitomate;
        float cuentaAguacate = ItemManager.aguacateCount * precioAguacate;
        float cuentaCafe = ItemManager.cafeCount * precioCafe;

        ItemManager.verCoinsCount = (int)(ItemManager.verCoinsCount + cuentaMaiz + cuentaChile + cuentaJitomate + cuentaAguacate + cuentaCafe);

    }
    public void RegresoASkyfall(){
        SceneManager.LoadScene("GameScene");
        numCiclo++;
    }

    public void resetCounts(){
        ItemManager.maizCount = 0;
        ItemManager.chileCount = 0;
        ItemManager.jitomateCount = 0;
        ItemManager.aguacateCount = 0;
        ItemManager.cafeCount = 0;
    }

}
