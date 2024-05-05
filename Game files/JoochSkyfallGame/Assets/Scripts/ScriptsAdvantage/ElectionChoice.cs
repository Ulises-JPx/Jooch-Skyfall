/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Clase para mostrar la seleccion de financiamiento en diferentes escenas
public class ElectionChoice : MonoBehaviour
{
    public GameObject PanelVerqor1;
    public GameObject PanelVerqor2;
    public GameObject PanelVerqor3;
    public GameObject PanelCoyote1;
    public GameObject PanelCoyote2;
    public GameObject PanelCoyote3;
    public GameObject PanelBanco1;
    public GameObject PanelBanco2;
    public GameObject PanelBanco3;
    //Inicialización de los paneles de elección de financiamiento
    void Start()
    {
        PanelVerqor1.SetActive(false);
        PanelVerqor2.SetActive(false);
        PanelVerqor3.SetActive(false);
        PanelCoyote1.SetActive(false);
        PanelCoyote2.SetActive(false);
        PanelCoyote3.SetActive(false);
        PanelBanco1.SetActive(false);
        PanelBanco2.SetActive(false);
        PanelBanco3.SetActive(false);
        DisplayChoice();
        
    }

    //Función para mostrar la elección de financiamiento
    public void DisplayChoice(){
        if (ElectionManager.TipoFinanciamiento == 1){
            PanelVerqor1.SetActive(true);
            PanelVerqor2.SetActive(true);
            PanelVerqor3.SetActive(true);
        }else if(ElectionManager.TipoFinanciamiento == 2){
            PanelCoyote1.SetActive(true);
            PanelCoyote2.SetActive(true);
            PanelCoyote3.SetActive(true);
        }else if(ElectionManager.TipoFinanciamiento == 3){
            PanelBanco1.SetActive(true);
            PanelBanco2.SetActive(true);
            PanelBanco3.SetActive(true);
        }
    }

}
