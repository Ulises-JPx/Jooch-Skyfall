using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CartaDisplay : MonoBehaviour
{
    [SerializeField] private GameObject StartingTransition;
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
        StartCoroutine(TurnoffTransition());
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
        
        if (carta.nombrecarta == "Comprador Nacional"){
            carta.VentajaCompradorNacional();
            SceneManager.LoadScene("RecapScene");
        }else if (carta.nombrecarta == "Nueva Certificacion"){
            carta.VentajaNuevaCertificacion();
            SceneManager.LoadScene("RecapScene");
        }else if (carta.nombrecarta == "Lluvia Moderada"){
            carta.VentajaLluviaModerada();
            SceneManager.LoadScene("RecapScene");
        }else if (carta.nombrecarta == "Negociacion Inteligente"){
            carta.VentajaNegociacionInteligente();
            SceneManager.LoadScene("RecapScene");
        }else if (carta.nombrecarta == "Reduccion de Deuda"){
            carta.VentajaReduccionDeDeuda();
            SceneManager.LoadScene("RecapScene");
        }else if (carta.nombrecarta == "Venta Exitosa"){
            carta.VentajaVentaExitosa();
            SceneManager.LoadScene("RecapScene");
        }
    }

    IEnumerator TurnoffTransition()
    {
        yield return new WaitForSeconds(3f);
        StartingTransition.SetActive(false);
    }
    
}