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
        else if (carta.V_titulo == "Nueva Certificación")
        {
            carta.VentajaNuevaCertificacion();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Lluvia Moderada")
        {
            carta.VentajaLluviaModerada();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Reducción de la Deuda")
        {
            carta.VentajaReduccionDeDeuda();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Venta Exitosa")
        {
            carta.VentajaVentaExitosa();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Negociación Inteligente"){
            carta.VentajaNegociacionInteligente();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Avance Tecnológico"){
            carta.VentajaAvanceTecnologico();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Optimización de Recursos"){
            carta.VentajaOptimizacionRecursos();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Estrategia de Comercialización"){
            carta.VentajaEstrategiaComercializacion();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Cosecha Dorada"){
            carta.VentajaCosechaDorada();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Festival del Chile"){
            carta.VentajaFestivalChile();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Despertar Aromático"){
            carta.VentajaDespertarAromatico();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Boom del Oro Verde"){
            carta.VentajaBoomOroVerde();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Avance Rojo"){
            carta.VentajaAvanceRojo();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Acceso a  Agroinsumos Sostenibles"){
            carta.VentajaAccesoAgroinsumos();
            SceneManager.LoadScene("RecapScene");
        }
        else if (carta.V_titulo == "Optimización del Ciclo Productivo"){
            carta.VentajaOptimizacionCiclo();
            SceneManager.LoadScene("RecapScene");
        }
        
    }

    IEnumerator TurnoffTransition()
    {
        yield return new WaitForSeconds(3f);
        StartingTransition.SetActive(false);
    }

}