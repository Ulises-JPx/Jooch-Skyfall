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
            Am.aguacateCount ++;
           
        }
        if (collision.gameObject.CompareTag("Cafe"))
        {
            Destroy(collision.gameObject);
            Am.cafeCount ++;
        }
        if (collision.gameObject.CompareTag("Jitomate"))
        {
            Destroy(collision.gameObject);
            Am.jitomateCount ++;
        }
        if (collision.gameObject.CompareTag("Maiz"))
        {
            Destroy(collision.gameObject);
            Am.maizCount ++;
        }
    }

    
}
