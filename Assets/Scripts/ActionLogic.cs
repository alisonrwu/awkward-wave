using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionLogic : MonoBehaviour {

    public Transform sightStart;

    public Transform hfRangeEnd;
    public bool canHF = false;
    public Transform waveRangeEnd;
    public bool canWave = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Raycasting();
	}

    void Raycasting() {
        //Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);
        //spotted = Physics2D.Linecast(sightStart.position, sightEnd.position);//, 1 << LayerMask.NameToLayer("Player"));

        //Debug.DrawLine(sightStart.position, hfRangeEnd.position, Color.magenta);
        canHF = Physics2D.Linecast(sightStart.position, hfRangeEnd.position);
        //Debug.DrawLine(sightStart.position, waveRangeEnd.position, Color.cyan);
        canWave = Physics2D.Linecast(sightStart.position, waveRangeEnd.position);
    }

}
