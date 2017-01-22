using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour {

    //RunningLeft -> if happy and despawn -->lower awkBar
    RunningLeft rl;
    AwkwardController ac;

    void Awake()
    {
        //rl = this.GetComponent<RunningLeft>();
        //ac = GetComponent<AwkwardController>();
    }

    void OnBecameInvisible()
    {
        //if (!rl.happy)
        //{
        //    Debug.Log("missed a person");
        //    ac.lowerAwkwardHealth();
        //}
        Destroy(gameObject);
    }

}
