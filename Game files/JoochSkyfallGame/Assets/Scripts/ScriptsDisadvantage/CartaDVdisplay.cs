using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CartaDVdisplay : MonoBehaviour
{
    public List<CartaDV> cartasDv;
    public CartaDV cartaDv;

    public TextMeshProUGUI nombrecartaDv;
    public TextMeshProUGUI descripcionDesventaja;
    public TextMeshProUGUI desventajaVerqor;
    public TextMeshProUGUI desventajaCoyote;
    public TextMeshProUGUI desventajaBanco;
    public Image arteCartaDv;
    void Start()
    {
         generateCard();
    }

    public void generateCard(){
        cartaDv = cartasDv[Random.Range(0, cartasDv.Count)];
         
        nombrecartaDv.text = cartaDv.nombrecartaDv;
        descripcionDesventaja.text = cartaDv.descripcionDesventaja;
        desventajaVerqor.text = cartaDv.desventajaVerqor;
        desventajaCoyote.text = cartaDv.desventajaCoyote;
        desventajaBanco.text = cartaDv.desventajaBanco;
        arteCartaDv.sprite = cartaDv.arteCartaDv;  
    }

    public void VentajasBoton(){
        
        if (cartaDv.nombrecartaDv == "Fortuna"){
            
            SceneManager.LoadScene("RecapScene");
        }else if (cartaDv.nombrecartaDv == "Fortuna2"){
            
            SceneManager.LoadScene("RecapScene");
        }else if (cartaDv.nombrecartaDv == "Lluvia Diaria"){
            
            SceneManager.LoadScene("RecapScene");
        }else if (cartaDv.nombrecartaDv == "Pago Deuda"){
            
            SceneManager.LoadScene("RecapScene");
        }


    }
}