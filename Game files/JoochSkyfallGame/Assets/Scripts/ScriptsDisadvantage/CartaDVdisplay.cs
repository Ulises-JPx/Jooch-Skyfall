using System.Collections.Generic;
using TMPro;
using UnityEngine;
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
    // public Image arteCartaDv;
    void Start()
    {
         GenerateCard();
    }

    public void GenerateCard(){
        cartaDv = cartasDv[Random.Range(0, cartasDv.Count)];
         
        nombrecartaDv.text = cartaDv.D_titulo;
        descripcionDesventaja.text = cartaDv.D_descripcion;
        desventajaVerqor.text = cartaDv.D_verqor;
        desventajaCoyote.text = cartaDv.D_coyote;
        desventajaBanco.text = cartaDv.D_canco;
        // arteCartaDv.sprite = cartaDv.D_img;  // Descomenta esta línea si añades una imagen a tu clase CartaDV
    }

    public void DesventajasBoton(){
        
        if (cartaDv.D_titulo == "Siniestro De Helada"){
            cartaDv.DesventajaSiniestroHelada();
            SceneManager.LoadScene("RecapScene");
        }else if (cartaDv.D_titulo == "Siniestro De Sequia"){
            cartaDv.DesventajaSiniestroSequia();
            SceneManager.LoadScene("RecapScene");
        }else if (cartaDv.D_titulo == "Enfermedad"){
            cartaDv.DesventajaEnfermedad();
            SceneManager.LoadScene("RecapScene");
        }else if (cartaDv.D_titulo == "Pago Deuda"){
            SceneManager.LoadScene("RecapScene");
        }
    }
}