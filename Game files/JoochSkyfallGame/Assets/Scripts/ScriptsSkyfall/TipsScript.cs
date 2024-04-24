using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsSCript : MonoBehaviour
{
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

    void Start()
    {
        
        panelCinteotl.SetActive(false);
        panelTextCinteotl.SetActive(false);
        PanelPadreCinteotl.SetActive(false);
        panelEagle.SetActive(false);
        panelTextEagle.SetActive(false);
        PanelPadreEagle.SetActive(false);


        // Inicia la Coroutine para activar el primer panel después de un retraso
        StartCoroutine(ActivateRandomTip());
    }

    IEnumerator ActivateCinteotlTip(){
        // Espera el tiempo de retraso antes de activar la llegada de Cinteotl
        yield return new WaitForSeconds(delayLLegadaCinteotl);
        PanelPadreCinteotl.SetActive(true);
        panelCinteotl.SetActive(true);

        // Espera el tiempo de retraso antes de activar el texto del tip
        yield return new WaitForSeconds(delayTipCinteotl);
        panelTextCinteotl.SetActive(true);
        Instantiate(VerqorColl, new Vector3(6, -3, 0),Quaternion.identity);

        // Espera el tiempo de retraso antes de desactivar los paneles
        yield return new WaitForSeconds(delaySalidaCinteotl);
        PanelPadreCinteotl.SetActive(false);
        panelTextCinteotl.SetActive(false);
        panelCinteotl.SetActive(false);
    }
    IEnumerator ActivateEagleTip(){
        // Espera el tiempo de retraso antes de activar la llegada de Eagle
        yield return new WaitForSeconds(10f);
        PanelPadreEagle.SetActive(true);
        panelEagle.SetActive(true);

        // Espera el tiempo de retraso antes de activar el texto del tip
        yield return new WaitForSeconds(4f);
        panelTextEagle.SetActive(true);
        Instantiate(VerqorColl, new Vector3(0, 8, 0),Quaternion.identity);

        // Espera el tiempo de retraso antes de desactivar los paneles
        yield return new WaitForSeconds(11f);
        PanelPadreEagle.SetActive(false);
        panelTextEagle.SetActive(false);
        panelEagle.SetActive(false);

    }
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
}
