/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
//Llamar a la librerias que se utilizarám
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

//Clase para que funcione la escena de recapitulación
public class RecapScript : MonoBehaviour
{
    //Definir variables y referencias a unity
    public GameObject StartStransition;
    public GameObject EndingTransition;
    float varParaText0;
    public TextMeshProUGUI varParaText0Text;
    float varParaText10;
    public TextMeshProUGUI varParaText10Text;
    float varParaText20;
    public TextMeshProUGUI varParaText20Text;
    float PagoDeuda = 0;
    float costoApagarCiclo;
    public TextMeshProUGUI costoApagarCicloText;
    float costosCiclo;
    float interesCiclo;
    float gastosFijos;

    public TextMeshProUGUI gastosFijosText;
    public static float CostosAgua = 100;
    public TextMeshProUGUI costosAguaText;
    public static float CosotsLuz = 100;
    public TextMeshProUGUI costosLuzText;
    public static float CostosDistribucion = 100;
    public TextMeshProUGUI costosDistribucionText; 
    public static float vercoinsVentaTEMP; //Aqui se guarda la suma de la recolecta total del ciclo
    public TextMeshProUGUI vercoinsVentaTempText;
    public static int numCiclo = 1;
    public TextMeshProUGUI cicloText;
    public static float precioMaiz = 80;
    public TextMeshProUGUI precioMaizText;
    public static float precioChile = 81;
    public TextMeshProUGUI precioChileText;
    public static float precioJitomate = 82;
    public TextMeshProUGUI precioJitomateText;
    public static float precioAguacate = 83;
    public TextMeshProUGUI precioAguacateText;
    public static float precioCafe = 84;
    public TextMeshProUGUI precioCafeText;
    public TextMeshProUGUI verCoinsCount;
    public TextMeshProUGUI deuda;
    public TextMeshProUGUI interes;

    // Funcion de star en la que se administran valores iniciales y estados de trancisiones.
    void Start()
    {
        EndingTransition.SetActive(false);
        gastosInteresCiclo();
        CalculoVercoins();
        varParaText0 = ItemManager.verCoinsCount * 0f;
        varParaText10 = ItemManager.verCoinsCount * 0.10f;
        varParaText20 = ItemManager.verCoinsCount * 0.20f;
        StartCoroutine(TurnoffStartTransition());
    }

    // Funcion update que actualizrá los valores de las variables en la pantalla
    void Update()
    {
        cicloText.text = "Ciclo: " + numCiclo;
        precioMaizText.text = "$" + Math.Round(precioMaiz, 2);
        precioChileText.text = "$" + Math.Round(precioChile, 2);
        precioJitomateText.text = "$" + Math.Round(precioJitomate, 2);
        precioAguacateText.text = "$" + Math.Round(precioAguacate, 2);
        precioCafeText.text = "$" + Math.Round(precioCafe, 2);
        verCoinsCount.text = "$" + ItemManager.verCoinsCount;
        deuda.text = "$" + ElectionManager.deuda;
        vercoinsVentaTempText.text = "$" + vercoinsVentaTEMP;
        interes.text = "" + ElectionManager.interes + "%";
        costosAguaText.text = "Costo de Agua: $" + CostosAgua;
        costosLuzText.text = "Costo de Energia: $" + CosotsLuz;
        costosDistribucionText.text = "Costo de Distribución: $" + CostosDistribucion;
        gastosFijosText.text = "Gastos Fijos: $" + gastosFijos;
        costoApagarCicloText.text = "$" + costoApagarCiclo;
        varParaText0Text.text = "$" + varParaText0;
        varParaText10Text.text = "$" + varParaText10;
        varParaText20Text.text = "$" + varParaText20;

    }
    //Esta funcion calcula las vercoins que se obtienen por la venta de los productos
    public void CalculoVercoins(){
        float cuentaMaiz = ItemManager.maizCount * precioMaiz;
        float cuentaChile = ItemManager.chileCount * precioChile;
        float cuentaJitomate = ItemManager.jitomateCount * precioJitomate;
        float cuentaAguacate = ItemManager.aguacateCount * precioAguacate;
        float cuentaCafe = ItemManager.cafeCount * precioCafe;

        ItemManager.verCoinsCount = (int)(ItemManager.verCoinsCount + cuentaMaiz + cuentaChile + cuentaJitomate + cuentaAguacate + cuentaCafe);
        vercoinsVentaTEMP = (int)(cuentaMaiz + cuentaChile + cuentaJitomate + cuentaAguacate + cuentaCafe);

    }
    //Funcion para regresar a la escena de juego y guardar los datos en una estructura
    //Esta funcion contiene la lógica de terminación de juego para cualquiera de las posibles eventualidades.
    public void RegresoASkyfall(){
        DataSaver.Recolectar();
        StartCoroutine(UpdatePlayer.UpdatePlayerData());
        
        PagarDeudaEnRegreso();
        gastosInteresCiclo();
        pagoCostos();
        resetCounts();
        
        DataSaver.Ciclo(numCiclo, ElectionManager.deuda, ItemManager.verCoinsCount, ElectionManager.interes);
        numCiclo++;
        
        if (ItemManager.verCoinsCount <= 0 || ElectionManager.deuda >= 50000)
        {
            DataSaver.Partida(ElectionManager.TipoFinanciamiento, CalculadorPuntaje.GetPuntaje(), ItemManager.verCoinsCount);
            StartCoroutine(UpdatePlayer.UpdatePlayerPartida());
            SceneManager.LoadScene("LoserScene");
        }
        else if (ElectionManager.deuda <= 0)
        {
            DataSaver.Partida(ElectionManager.TipoFinanciamiento, CalculadorPuntaje.GetPuntaje(), ItemManager.verCoinsCount);
            StartCoroutine(UpdatePlayer.UpdatePlayerPartida());
            SceneManager.LoadScene("WinnerScene");
        }else {
            DataSaver.Resetear();
            StartCoroutine(StartEndingTransition());
        }
    }
    //Funcion para resetear los contadores de los productos y las vercoins
    public void resetCounts(){
        ItemManager.maizCount = 0;
        ItemManager.chileCount = 0;
        ItemManager.jitomateCount = 0;
        ItemManager.aguacateCount = 0;
        ItemManager.cafeCount = 0;
        vercoinsVentaTEMP = 0;
    }
    //Funcion para pagar los costos del ciclo
    public void pagoCostos(){
        
        ItemManager.verCoinsCount = ItemManager.verCoinsCount - (int)costoApagarCiclo;
        ElectionManager.deuda = ElectionManager.deuda + (int)interesCiclo;

    }
    //Funcion para calcular los gastos fijos y los intereses del ciclo
    public void gastosInteresCiclo(){
        gastosFijos = precioAguacate + precioCafe + precioChile + precioJitomate + precioMaiz;
        costosCiclo = CostosAgua + CosotsLuz + CostosDistribucion;
        interesCiclo = ElectionManager.deuda * (ElectionManager.interes/100);
        costoApagarCiclo = costosCiclo + gastosFijos  + PagoDeuda;
    }
    //Funcions para pagar la deuda por porcentajes.
    public void NopagarDeuda(){
        PagoDeuda = 0; 
        gastosInteresCiclo();
    }
    public void pagarDeuda10(){
        PagoDeuda = ItemManager.verCoinsCount * 0.10f;
        gastosInteresCiclo();
    }	
    public void pagarDeuda20(){
        PagoDeuda = ItemManager.verCoinsCount * 0.20f;
        gastosInteresCiclo();
    }
    public void PagarDeudaEnRegreso(){
        ElectionManager.deuda = ElectionManager.deuda - (int)PagoDeuda;
    }


    //Corutinas para las transiciones de la escena
    IEnumerator TurnoffStartTransition()
    {
        
        yield return new WaitForSeconds(1.5f); 
        StartStransition.SetActive(false);// Espera 3 segundos
    }
    IEnumerator StartEndingTransition()
    {
        EndingTransition.SetActive(true);
        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene("GameScene");
    }
}
