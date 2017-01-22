using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningAll : MonoBehaviour {
    // Use this for initialization
    public float dir;
    public float flyDir;

    void Start () {
    }

    // Update is called once per frame
    void Update () {
        //   Vector3 position = this.transform.position;
        //   position.x -= 0.05f;
        //   this.transform.position = position;
        RunDirection(dir);
        FlyDirection(flyDir);
    }


    void RunDirection (float dir)
    {
        Vector3 position = this.transform.position;
        position.x += dir;
        this.transform.position = position;
    }


    void FlyDirection(float flyDir)
    {
        Vector3 position = this.transform.position;
        position.y += dir;
        this.transform.position = position;
    }

}
