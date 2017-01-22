using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
    public GameObject[] enemies; 
    //public GameObject enemy;
    public float spawnTime = 0.5f;
    private float nextSpawnTime;
    private float Timer; 
  

    // Use this for initialization
    void Start () {
        Timer = Time.time + Random.Range(0.3f, 2.0f); 
        //InvokeRepeating("spawnEnemies", spawnTime, Random.Range(0.3f, 3.0f));
    }

    void Update() {
        if (Timer < Time.time) {
            spawnEnemies();
            Timer = Time.time + Random.Range(0.5f, 3.0f);

        }
    }


    void spawnEnemies()
    {
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length)], new Vector3(12, -3, 0), Quaternion.identity);
    }
}
