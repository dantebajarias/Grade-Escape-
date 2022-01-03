using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject collectible;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float minWait;
    public float maxWait;
    public float timeBetweenSpawn;
    private float spawnTime;
    private bool isSpawning;

    void Update()
    {
        if(Time.time > spawnTime){

            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        if(!isSpawning){
            float timer = Random.Range(minWait, maxWait);
            Invoke("SpawnCollectible", timer);
            isSpawning = true;
        }
    }

    void Spawn(){

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
    
    void SpawnCollectible(){

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        isSpawning = false;
        Instantiate(collectible, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
