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
//Clase para el efecto de la estela de los objetos normales
public class TrailRotten : MonoBehaviour
{
    // Referencia al TrailRenderer
    private TrailRenderer trail;
    //Inicializa el TrailRenderer con sus atributos correspondientes
    void Start()
    {
        // Obtiene la referencia al TrailRenderer
        trail = GetComponent<TrailRenderer>();

        trail.time = 0.5f;
        trail.startWidth = 0.4f;
        trail.endWidth = 0.0f;
        trail.material = new Material(Shader.Find("Sprites/Default"));
        trail.startColor = new Color(1f, 1f, 1f, 0.5f); // Blanco semitransparente
        trail.endColor = new Color(1f, 1f, 1f, 0f);
        trail.sortingOrder = -1;

        

        
    }
}
