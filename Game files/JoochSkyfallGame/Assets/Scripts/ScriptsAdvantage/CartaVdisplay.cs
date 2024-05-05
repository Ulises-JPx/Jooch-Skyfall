/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
//Clase para mostrar las cartas de ventajas y sus respectivas acciones
public class CartaVdisplay : MonoBehaviour
{
    //Variables de la clase y referencias a lo elementos de la interfaz en unity
    [SerializeField] private GameObject StartingTransition;
    public GameObject TransitionEnding;

    public static List<CartaV> cartas;
    public CartaV carta;

    public TextMeshProUGUI titulo;
    public TextMeshProUGUI descripcion;
    public TextMeshProUGUI verqor;
    public TextMeshProUGUI coyote;
    public TextMeshProUGUI banco;
    // public Image arte;
    //Inicialización de la lista de cartas de ventajas y trancisiones
    void Start()
    {
        TransitionEnding.SetActive(false);
        cartas = new List<CartaV>(Resources.LoadAll<CartaV>("Ventajas"));
        StartCoroutine(TurnoffTransition());
        GenerateCard();
    }

    //Función para generar una carta de ventaja aleatoria
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

    //Función para seleccionar una carta de ventaja y mostrar sus respectivas acciones
    public void VentajasBoton()
    {
        int id_carta = carta.V_id;
        string tipo = "V";

        DataSaver.Seleccion(id_carta, tipo);

        if (carta.V_titulo == "Comprador nacional")
        {
            carta.VentajaCompradorNacional();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Nueva certificación")
        {
            carta.VentajaNuevaCertificacion();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Lluvia Moderada")
        {
            carta.VentajaLluviaModerada();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Reducción de la Deuda")
        {
            carta.VentajaReduccionDeDeuda();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Venta Exitosa")
        {
            carta.VentajaVentaExitosa();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Negociación Inteligente"){
            carta.VentajaNegociacionInteligente();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Avance Tecnológico"){
            carta.VentajaAvanceTecnologico();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Optimización de Recursos"){
            carta.VentajaOptimizacionRecursos();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Estrategia de Comercialización"){
            carta.VentajaEstrategiaComercializacion();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Cosecha Dorada"){
            carta.VentajaCosechaDorada();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Festival del Chile"){
            carta.VentajaFestivalChile();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Despertar Aromático"){
            carta.VentajaDespertarAromatico();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Boom del Oro Verde"){
            carta.VentajaBoomOroVerde();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Avance Rojo"){
            carta.VentajaAvanceRojo();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Acceso a Agroinsumos Sostenibles"){
            carta.VentajaAccesoAgroinsumos();
            StartCoroutine(StartTransitionEnding());
        }
        else if (carta.V_titulo == "Optimización del Ciclo Productivo"){
            carta.VentajaOptimizacionCiclo();
            StartCoroutine(StartTransitionEnding());
        }
        
    }
    //Corutina para la transición de la interfaz
    IEnumerator TurnoffTransition()
    {
        yield return new WaitForSeconds(3f);
        StartingTransition.SetActive(false);
    }
    //Corutina para la transición de la interfaz
    IEnumerator StartTransitionEnding()
    {
        TransitionEnding.SetActive(true);
        yield return new WaitForSeconds(.8f);
        SceneManager.LoadScene("RecapScene");
    }

}