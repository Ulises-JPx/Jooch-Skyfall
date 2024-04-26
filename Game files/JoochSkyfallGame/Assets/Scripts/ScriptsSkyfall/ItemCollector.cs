using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    [SerializeField] public ItemManager Am;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Aguacate"))
        {
            Destroy(collision.gameObject);
            ItemManager.aguacateCount ++;
           
        }
        if (collision.gameObject.CompareTag("Cafe"))
        {
            Destroy(collision.gameObject);
            ItemManager.cafeCount ++;
        }
        if (collision.gameObject.CompareTag("Jitomate"))
        {
            Destroy(collision.gameObject);
            ItemManager.jitomateCount ++;
        }
        if (collision.gameObject.CompareTag("Maiz"))
        {
            Destroy(collision.gameObject);
            ItemManager.maizCount ++;
        }
        if (collision.gameObject.CompareTag("Chile"))
        {
            Destroy(collision.gameObject);
            ItemManager.chileCount ++;
        }
        if (collision.gameObject.CompareTag("RottenAguacate"))
        {
            Destroy(collision.gameObject);
            ItemManager.aguacateCount --;
        }
        if (collision.gameObject.CompareTag("RottenCafe"))
        {
            Destroy(collision.gameObject);
            ItemManager.cafeCount --;
        }
        if (collision.gameObject.CompareTag("RottenJitomate"))
        {
            Destroy(collision.gameObject);
            ItemManager.jitomateCount --;
        }
        if (collision.gameObject.CompareTag("RottenMaiz"))
        {
            Destroy(collision.gameObject);
            ItemManager.maizCount --;
        }
        if (collision.gameObject.CompareTag("RottenChile"))
        {
            Destroy(collision.gameObject);
            ItemManager.chileCount --;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("LVerqor"))
        {
            Destroy(collision.gameObject);
            Am.verqorCount ++;
        }
    }
    
}
