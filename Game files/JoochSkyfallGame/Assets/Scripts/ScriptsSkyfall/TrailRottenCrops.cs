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
//Clase para el rastro de los cultivos podridos
public class TrailRottenCrops : MonoBehaviour
{
    // Referencia al TrailRenderer
    private TrailRenderer trail;

    void Start()
    {
        // Obtiene la referencia al TrailRenderer
        trail = GetComponent<TrailRenderer>();

        trail.time = 0.5f;
        trail.startWidth = 0.4f;
        trail.endWidth = 0.0f;
        trail.material = new Material(Shader.Find("Sprites/Default"));
        trail.startColor = new Color(112f / 255f, 128f / 255f, 34f / 255f, 1f);
        trail.endColor = new Color(112f / 255f, 128f / 255f, 34f / 255f, 0.5f);
        trail.sortingOrder = -1;

        
        
    }
}
