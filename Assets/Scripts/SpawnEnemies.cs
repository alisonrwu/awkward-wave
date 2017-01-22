using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
    public GameObject[] enemies; 
    //public GameObject enemy;
    public float spawnTime = 0.5f;
    public float spawnRepeat;  

    // Use this for initialization
    void Start () {
        spawnRepeat = Random.Range(0.5f, 5.0f); 
        InvokeRepeating("spawnEnemies", spawnTime, spawnRepeat);
    }

    void spawnEnemies()
    {
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length)], new Vector3(12, -3, 0), Quaternion.identity);
    }
}
