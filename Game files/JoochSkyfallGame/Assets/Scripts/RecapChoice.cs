/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
//Llamar a la librerias que se utilizarám
using UnityEngine;
//Clase para que se vea la elección de financiamiento durante las escenas del juego.
public class RecapChoice : MonoBehaviour
{
    //Definir variables y referencias a unity
    public GameObject PanelVerqor1;
    public GameObject PanelCoyote1;
    public GameObject PanelBaqnco1;
    // Funcion start que apaga los paneles y llama a la función DisplayChoice
    void Start()
    {
        PanelVerqor1.SetActive(false);
        PanelCoyote1.SetActive(false);
        PanelBaqnco1.SetActive(false);
        DisplayChoice();
    }
    //Función para mostrar el panel de elección de financiamiento

    public void DisplayChoice(){
        if (ElectionManager.TipoFinanciamiento == 1){
            PanelVerqor1.SetActive(true);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            PanelCoyote1.SetActive(true);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            PanelBaqnco1.SetActive(true);
        }
    }
}
