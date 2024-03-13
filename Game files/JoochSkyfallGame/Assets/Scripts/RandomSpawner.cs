using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject RainingObject;
    private float maxX = 8.23f;
    private float minX = -8.23f;
    private float maxY = 9f;
    private float minY = 6f;
    public float spawnInterval;
    private float SpawnTime;



    void Update() {
        
        if(Time.time > SpawnTime){
            Spawm();
            SpawnTime = Time.time + spawnInterval;
        }
    }

    void Spawm(){
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY); 

        GameObject spawnedObject = Instantiate(RainingObject, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedObject, 10f);
    }
}
