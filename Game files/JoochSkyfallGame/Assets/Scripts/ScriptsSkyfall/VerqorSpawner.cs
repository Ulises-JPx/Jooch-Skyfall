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
//Clase para spawnear los logos de verqor
public class VerqorSpawner : MonoBehaviour
{
    //Referencia al prefab de los logos de verqor e inicializar variables
    public GameObject RainingVerqor;
     private float maxX = 8.23f;
    private float minX = -8.23f;
    private float maxY = 15f;
    private float minY = 6f;
    public float spawnInterval;
    private float SpawnTime;
    // Checa el tiempo para spawnear los logos de verqor
    void Update()
    {
        if(Time.time > SpawnTime){
            Spawm();
            SpawnTime = Time.time + spawnInterval;
        }
    }
    //Funcion para instanciar  los logos de verqor

    void Spawm(){
        float x, y;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedObject = Instantiate(RainingVerqor, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        
    }

}
