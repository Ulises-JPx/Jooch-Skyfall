using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CartaVdisplay : MonoBehaviour
{
    [SerializeField] private GameObject StartingTransition;
    public static List<CartaV> cartas;
    public CartaV carta;

    public TextMeshProUGUI titulo;
    public TextMeshProUGUI descripcion;
    public TextMeshProUGUI verqor;
    public TextMeshProUGUI coyote;
    public TextMeshProUGUI banco;
    // public Image arte;
    void Start()
    {
        cartas = new List<CartaV>(Resources.LoadAll<CartaV>("Ventajas"));
        StartCoroutine(TurnoffTransition());
        GenerateCard();
    }

    public void GenerateCard()
    {
        carta = cartas[Random.Range(0, cartas.Count)];

        titulo.text = carta.V_titulo;
        descripcion.text = carta.V_descripcion;
        verqor.text = carta.V_verqor;
        coyote.text = carta.V_coyote;
        banco.text = carta.V_canco;
        // arte.sprite = carta.V_img;  
    }

    public void VentajasBoton()
    {

        if (carta.V_titulo == "Comprador Nacional")
        {
            carta.VentajaCompradorNacional();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Nueva Certificacion")
        {
            carta.VentajaNuevaCertificacion();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Lluvia Moderada")
        {
            carta.VentajaLluviaModerada();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Negociacion Inteligente")
        {
            carta.VentajaNegociacionInteligente();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Reduccion de Deuda")
        {
            carta.VentajaReduccionDeDeuda();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Venta Exitosa")
        {
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