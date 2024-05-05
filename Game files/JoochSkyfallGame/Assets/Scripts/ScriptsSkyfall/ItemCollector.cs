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
using UnityEngine.UI;

//Clase para que el personaje pueda recolectar los items
public class ItemCollector : MonoBehaviour
{
    //Variables para los items y referencias
    [SerializeField] public ItemManager Am;
    public AudioSource collector;
    public AudioClip collectSound;

    //Función para recolectar los items y emitir el sonido de recolección
    private void OnTriggerEnter2D(Collider2D collision){
        collector.clip = collectSound;
        
        if (collision.gameObject.CompareTag("Aguacate"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.aguacateCount ++;
           
        }
        if (collision.gameObject.CompareTag("Cafe"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.cafeCount ++;
        }
        if (collision.gameObject.CompareTag("Jitomate"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.jitomateCount ++;
        }
        if (collision.gameObject.CompareTag("Maiz"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.maizCount ++;
        }
        if (collision.gameObject.CompareTag("Chile"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.chileCount ++;
        }
        if (collision.gameObject.CompareTag("RottenAguacate"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.aguacateCount --;
        }
        if (collision.gameObject.CompareTag("RottenCafe"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.cafeCount --;
        }
        if (collision.gameObject.CompareTag("RottenJitomate"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.jitomateCount --;
        }
        if (collision.gameObject.CompareTag("RottenMaiz"))
        {   
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.maizCount --;
        }
        if (collision.gameObject.CompareTag("RottenChile"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            ItemManager.chileCount --;
        }
    }
    //Función para recolectar los verqors y emitir el sonido de recolección
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("LVerqor"))
        {
            collector.Play();
            Destroy(collision.gameObject);
            Am.verqorCount ++;
        }
    }
    
}
