using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject RainingObject;
    public GameObject RainingObject2;
    public GameObject RainingObject3;
    public GameObject RainingObject4;
    public GameObject RainingObject5;
    private float maxX = 8.23f;
    private float minX = -8.23f;
    private float maxY = 15f;
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
        float x, y;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedObject = Instantiate(RainingObject, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedObject, 7f);

        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedObject1 = Instantiate(RainingObject2, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedObject1, 7f);

        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedObject2 = Instantiate(RainingObject3, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedObject2, 7f);

        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedObject3 = Instantiate(RainingObject4, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedObject3, 7f);

        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedObject4 = Instantiate(RainingObject5, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedObject4, 7f);
    }
}
