using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour {

    //RunningLeft -> if happy and despawn -->lower awkBar

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
