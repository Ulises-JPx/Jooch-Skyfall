using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CartaDisplay : MonoBehaviour
{
    public List<CartaD> cartasD;
    public CartaD cartaD;

    public TextMeshProUGUI titulo;
    public TextMeshProUGUI descripcion;
    public TextMeshProUGUI verqor;
    public TextMeshProUGUI coyote;
    public TextMeshProUGUI banco;
    // public Image arte;

    void Start()
    {
        cartasD = new List<CartaD>(Resources.LoadAll<CartaD>("Desventajas"));
        GenerateCard();
    }

    public void GenerateCard()
    {
        cartaD = cartasD[Random.Range(0, cartasD.Count)];

        titulo.text = cartaD.D_titulo;
        descripcion.text = cartaD.D_descripcion;
        verqor.text = cartaD.D_verqor;
        coyote.text = cartaD.D_coyote;
        banco.text = cartaD.D_banco;
        // arteCartaD.sprite = cartaD.D_img;  // Descomenta esta línea si añades una imagen a tu clase CartaD
    }

    public void DesventajasBoton()
    {
        if (cartaD.D_titulo == "Siniestro De Helada")
        {
            cartaD.DesventajaSiniestroHelada();
            SceneManager.LoadScene("RecapScene");
        }
        else if (cartaD.D_titulo == "Siniestro De Sequia")
        {
            cartaD.DesventajaSiniestroSequia();
            SceneManager.LoadScene("RecapScene");
        }
        else if (cartaD.D_titulo == "Enfermedad")
        {
            cartaD.DesventajaEnfermedad();
            SceneManager.LoadScene("RecapScene");
        }
        else if (cartaD.D_titulo == "Pago Deuda")
        {
            SceneManager.LoadScene("RecapScene");
        }
    }
}