using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerqorSpawner : MonoBehaviour
{
    public GameObject RainingVerqor;
     private float maxX = 8.23f;
    private float minX = -8.23f;
    private float maxY = 15f;
    private float minY = 6f;
    public float spawnInterval;
    private float SpawnTime;
    // Update is called once per frame
    void Update()
    {
        if(Time.time > SpawnTime){
            Spawm();
            SpawnTime = Time.time + spawnInterval;
        }
    }

    void Spawm(){
        float x, y;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedObject = Instantiate(RainingVerqor, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        
    }

}
