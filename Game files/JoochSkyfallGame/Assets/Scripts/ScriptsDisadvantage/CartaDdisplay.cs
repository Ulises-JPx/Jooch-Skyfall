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
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
//Clase para mostrar las cartas de desventajas y sus respectivas acciones
public class CartaDisplay : MonoBehaviour
{   
    //Variables de la clase y referencias a lo elementos de la interfaz en unity
    public GameObject StartingTransition;
    public GameObject TransitionEnding;
    public List<CartaD> cartasD;
    public CartaD cartaD;

    public TextMeshProUGUI titulo;
    public TextMeshProUGUI descripcion;
    public TextMeshProUGUI verqor;
    public TextMeshProUGUI coyote;
    public TextMeshProUGUI banco;
    // public Image arte;

    //Inicialización de la lista de cartas de desventajas y trancisiones
    void Start()
    {
        TransitionEnding.SetActive(false);
        cartasD = new List<CartaD>(Resources.LoadAll<CartaD>("Desventajas"));
        StartCoroutine(TurnoffTransition());
        GenerateCard();
    }

    //Función para generar una carta de desventaja aleatoria
    public void GenerateCard()
    {
        cartaD = cartasD[Random.Range(0, cartasD.Count)];

        titulo.text = cartaD.D_titulo;
        descripcion.text = cartaD.D_descripcion;
        verqor.text = cartaD.D_verqor;
        coyote.text = cartaD.D_coyote;
        banco.text = cartaD.D_banco;
        // arteCartaD.sprite = cartaD.D_img;  
    }


    //Función para seleccionar una carta de desventaja y mostrar sus respectivas acciones
    public void DesventajasBoton()
    {
        int id_carta = cartaD.D_id;
        string tipo = "D";

        DataSaver.Seleccion(id_carta, tipo);
        
        if (cartaD.D_titulo == "Siniestro de Helada")
        {
            cartaD.DesventajaSiniestroHelada();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Siniestro de Sequía")
        {
            cartaD.DesventajaSiniestroSequia();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Enfermedad")
        {
            cartaD.DesventajaEnfermedad();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Plaga"){
            cartaD.DesventajaPlaga();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Gastos extra"){
            cartaD.DesventajaGatsosExtra();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Calor extremo"){
            cartaD.DesventajaCalorExtremo();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Engaño"){
            cartaD.DesventajaEngano();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Conflicto con el narco"){
            cartaD.DesventajaConflictoNarco();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Crisis de Mercado"){
            cartaD.DesventajaCrisisMercado();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Inundación"){
            cartaD.DesventajaInundacion();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Incremento de Costos"){
            cartaD.DesventajaIncrementoCostos();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Robo de Cosecha"){
            cartaD.DesventajaRoboCosecha();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Problemas de Logística"){
            cartaD.DesventajaProblemasLogistica();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Aumento de Tasas de Interés"){
            cartaD.DesventajaAumentotasas();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Tarifas de Exportación"){
            cartaD.DesventajaTarifaExortacion();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Escasez de Agua"){
            cartaD.DesventajaEscazesAgua();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Incendio"){
            cartaD.DesventajaIncendio();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Aumento del Costo Energético"){
            cartaD.DesventajaAumentoCostoEnergetico();
            StartCoroutine(StartTransitionEnding());
        }
        else if (cartaD.D_titulo == "Multas por Regulaciones"){
            cartaD.DesventajaMultasRegulaciones();
            StartCoroutine(StartTransitionEnding());
        }
        


    }
    //Corutinas para las transiciones de la interfaz
    IEnumerator TurnoffTransition()
    {
        yield return new WaitForSeconds(3f);
        StartingTransition.SetActive(false);
    }

    IEnumerator StartTransitionEnding()
    {
        TransitionEnding.SetActive(true);
        yield return new WaitForSeconds(.8f);
        SceneManager.LoadScene("RecapScene");
    }
}