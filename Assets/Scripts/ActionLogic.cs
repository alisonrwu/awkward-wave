using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionLogic : MonoBehaviour {

    public Transform sightStart, sightEnd;
    public bool spotted = false; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Raycasting();
	}

    void Raycasting() {
        Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);
        spotted = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Player"));
    }

}
