using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CartaDisplay : MonoBehaviour
{
    public List<CartaV> cartas;
    public CartaV carta;

    public TextMeshProUGUI nombrecarta;
    public TextMeshProUGUI descripcionVentaja;
    public TextMeshProUGUI ventajaVerqor;
    public TextMeshProUGUI ventajaCoyote;
    public TextMeshProUGUI ventajaBanco;
    public Image arteCarta;
    void Start()
    {
         generateCard();
    }

    public void generateCard(){
        carta = cartas[Random.Range(0, cartas.Count)];
         
        nombrecarta.text = carta.nombrecarta;
        descripcionVentaja.text = carta.descripcionVentaja;
        ventajaVerqor.text = carta.ventajaVerqor;
        ventajaCoyote.text = carta.ventajaCoyote;
        ventajaBanco.text = carta.ventajaBanco;
        arteCarta.sprite = carta.arteCarta;  
    }

    public void VentajasBoton(){
        
        if (carta.nombrecarta == "Fortuna"){
            carta.VentajaFortuna();
            SceneManager.LoadScene("RecapScene");
        }else if (carta.nombrecarta == "Fortuna2"){
            carta.VentajaFortuna2();
            SceneManager.LoadScene("RecapScene");
        }else if (carta.nombrecarta == "Lluvia Diaria"){
            carta.VentajaLluviaDiaria();
            SceneManager.LoadScene("RecapScene");
        }else if (carta.nombrecarta == "Pago Deuda"){
            carta.VentajaPagoDeuda();
            SceneManager.LoadScene("RecapScene");
        }


    }
}
