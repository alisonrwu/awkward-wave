using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningLeft : MonoBehaviour {
    // Use this for initialization

    void Start () {
    }

    // Update is called once per frame
    void Update () {
        Vector3 position = this.transform.position;
        position.x -= 0.05f;
        this.transform.position = position;
    }

}
