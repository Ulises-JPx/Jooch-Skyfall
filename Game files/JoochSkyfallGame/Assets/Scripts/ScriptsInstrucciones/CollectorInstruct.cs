using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorInstruct : MonoBehaviour
{
    public SpawnerInstruct spawnerInstruct; // referencia al script SpawnerInstruct

    // Contadores para cada tipo de objeto
    public int aguacateCount = 0;
    public int rottenAguacateCount = 0;
    public int lVerqorCount = 0;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Aguacate"))
        {
            Destroy(collision.gameObject);
            aguacateCount ++;
            spawnerInstruct.ObjectCaught(); // llamada al método ObjectCaught
        }
        if (collision.gameObject.CompareTag("RottenAguacate"))
        {
            Destroy(collision.gameObject);
            rottenAguacateCount ++;
            spawnerInstruct.ObjectCaught(); // llamada al método ObjectCaught
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("LVerqor"))
        {
            Destroy(collision.gameObject);
            lVerqorCount ++;
            spawnerInstruct.ObjectCaught(); // llamada al método ObjectCaught
        }
    }
}