using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {
    public GameObject[] enemies; 
    //public GameObject enemy;
    public float spawnTime = 5f;

    // Use this for initialization
    void Start () {
        InvokeRepeating("spawnEnemies", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void spawnEnemies()
    {
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length)], new Vector3(12, -3, 0), Quaternion.identity);
    }
}
