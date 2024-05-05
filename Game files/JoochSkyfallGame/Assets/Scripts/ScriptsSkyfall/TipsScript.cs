/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
//Clase para los tips del juego
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.CodeDom.Compiler;

public class TipsSCript : MonoBehaviour
{
    //Referencias a los paneles y textos de los tips
    public GameObject VerqorColl;
    public GameObject panelCinteotl; // Referencia al primer panel Cineteotl
    public GameObject panelTextCinteotl; // Referencia al segundo panel de texto
    public GameObject PanelPadreCinteotl; // Referencia al panel padre Cineotl
    public float delayTipCinteotl = 4.0f; // Tiempo de espera antes de mostrar el segundo panel
    public float delayLLegadaCinteotl = 10.0f;
    public float delaySalidaCinteotl = 6.0f;
    public GameObject panelEagle; // Referencia al primer panel Eagle
    public GameObject panelTextEagle; // Referencia al segundo panel de texto
    public GameObject PanelPadreEagle; // Referencia al panel padre Eagle

    public TextMeshProUGUI textoTipCinteotl; // Referencia al texto del tip de Cinteotl
    public TextMeshProUGUI textoTipEagle; // Referencia al texto del tip de Eagle
    public static List<TipsSO> tips;
    public static TipsSO tipCinteotl;
    public static TipsSO tipEagle;
    //Inicializar los paneles y la lista en la que se almacenarán los tips del juego
    void Start()
    {
        tips = new List<TipsSO>(Resources.LoadAll<TipsSO>("Tips"));
        panelCinteotl.SetActive(false);
        panelTextCinteotl.SetActive(false);
        PanelPadreCinteotl.SetActive(false);
        panelEagle.SetActive(false);
        panelTextEagle.SetActive(false);
        PanelPadreEagle.SetActive(false);
        // Inicia la Coroutine para activar el primer panel después de un retraso
        StartCoroutine(ActivateRandomTip());
    }
    //Corrutina para activar los tips de Cinteotl

    IEnumerator ActivateCinteotlTip(){
        // Espera el tiempo de retraso antes de activar la llegada de Cinteotl
        yield return new WaitForSeconds(delayLLegadaCinteotl);
        PanelPadreCinteotl.SetActive(true);
        panelCinteotl.SetActive(true);

        // Espera el tiempo de retraso antes de activar el texto del tip
        generateTipCinteotl();
        yield return new WaitForSeconds(delayTipCinteotl);
        panelTextCinteotl.SetActive(true);
        Instantiate(VerqorColl, new Vector3(6, -3, 0),Quaternion.identity);

        // Espera el tiempo de retraso antes de desactivar los paneles
        yield return new WaitForSeconds(delaySalidaCinteotl);
        PanelPadreCinteotl.SetActive(false);
        panelTextCinteotl.SetActive(false);
        panelCinteotl.SetActive(false);
    }
    //Corrutina para activar los tips de Eagle
    IEnumerator ActivateEagleTip(){
        // Espera el tiempo de retraso antes de activar la llegada de Eagle
        yield return new WaitForSeconds(10f);
        PanelPadreEagle.SetActive(true);
        panelEagle.SetActive(true);

        // Espera el tiempo de retraso antes de activar el texto del tip
        generateTipEagle();
        yield return new WaitForSeconds(4f);
        panelTextEagle.SetActive(true);
        Instantiate(VerqorColl, new Vector3(0, 8, 0),Quaternion.identity);

        // Espera el tiempo de retraso antes de desactivar los paneles
        yield return new WaitForSeconds(11f);
        PanelPadreEagle.SetActive(false);
        panelTextEagle.SetActive(false);
        panelEagle.SetActive(false);

    }
    //Corrutina para activar los tips de manera aleatoria
    IEnumerator ActivateRandomTip(){
        bool isCinteotlNext = true;
        while (true)
            {

        // Ejecuta la corutina seleccionada
            if (isCinteotlNext)
            {
                yield return StartCoroutine(ActivateCinteotlTip());
            }
            else
            {
                yield return StartCoroutine(ActivateEagleTip());
            }
            isCinteotlNext = !isCinteotlNext;

        // Espera un poco antes de iniciar la siguiente corutina
        yield return new WaitForSeconds(1f);
        }   
    }
    //Función para generar un tip de Cinteotl
    public void generateTipCinteotl(){
        tipCinteotl = tips[Random.Range(0, tips.Count)];

        textoTipCinteotl.text = tipCinteotl.T_Tip;
    }
    //Función para generar un tip de Eagle
    public void generateTipEagle(){
        tipEagle = tips[Random.Range(0, tips.Count)];

        textoTipEagle.text = tipEagle.T_Tip;
    }
}
