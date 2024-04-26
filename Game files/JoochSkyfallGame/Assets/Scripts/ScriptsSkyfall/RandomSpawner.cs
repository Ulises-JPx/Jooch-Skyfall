using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject RainingMaiz;
    public GameObject RainingAguacate;
    public GameObject RainingChile;
    public GameObject RainingCafe;
    public GameObject RainingJitomate;
    private float maxX = 8.23f;
    private float minX = -8.23f;
    private float maxY = 15f;
    private float minY = 6f;
    public static float spawnIntervalMaiz = 7f;
    public static float spawnIntervalAguacate = 9f;
    public static float spawnIntervalChile = 6f;
    public static float spawnIntervalCafe = 8f;
    public static float spawnIntervalJitomate = 10f;
    private float SpawnTimeMaiz;
    private float SpawnTimeAguacate;
    private float SpawnTimeChile;
    private float SpawnTimeCafe;
    private float SpawnTimeJitomate;



    void Update() {
        
        if(Time.time > SpawnTimeMaiz){
            SpawmMaiz();
            SpawnTimeMaiz = Time.time + spawnIntervalMaiz;
        }
        if(Time.time > SpawnTimeAguacate){
            SpawnAguacate();
            SpawnTimeAguacate = Time.time + spawnIntervalAguacate;
        }
        if(Time.time > SpawnTimeChile){
            SpawnChile();
            SpawnTimeChile = Time.time + spawnIntervalChile;
        }
        if(Time.time > SpawnTimeCafe){
            SpawnCafe();
            SpawnTimeCafe = Time.time + spawnIntervalCafe;
        }
        if(Time.time > SpawnTimeJitomate){
            SpawnJitomate();
            SpawnTimeJitomate = Time.time + spawnIntervalJitomate;
        }
    }

    void SpawmMaiz(){
        float x, y;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedMaiz = Instantiate(RainingMaiz, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedMaiz, 7f);
    }
    void SpawnAguacate(){
        float x, y;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedAguacate = Instantiate(RainingAguacate, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedAguacate, 7f);
    }
    void SpawnChile(){
        float x, y;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedChile = Instantiate(RainingChile, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedChile, 7f);
    }
    void SpawnCafe(){
        float x, y;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedCafe = Instantiate(RainingCafe, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedCafe, 7f);
    }
    void SpawnJitomate(){
        float x, y;
        x = Random.Range(minX, maxX);
        y = Random.Range(minY, maxY); 
        GameObject spawnedJitomate = Instantiate(RainingJitomate, transform.position + new UnityEngine.Vector3(x,y,0), transform.rotation);
        Destroy(spawnedJitomate, 7f);
    }	
}
