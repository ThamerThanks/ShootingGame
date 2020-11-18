using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 spawnLocation;
    public static float spawnRate = 2f;
    float nextSpawn = 0f;


    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-1.45f, 1.45f);
            spawnLocation = new Vector2(randX, 0.9f);
            Instantiate(enemy, spawnLocation, Quaternion.identity);
        }
        spawnRate = spawnRate - 0.0001f;
    }
}
