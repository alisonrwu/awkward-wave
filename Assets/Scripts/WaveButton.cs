using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveButton : MonoBehaviour {

    public GameObject red;
    public GameObject[] allEnemies;
    public Vector3 dist;
    public Transform pos;

    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();
    }

	// Use this for initialization
	void Start () {
        button.onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        Debug.Log("Hello");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void wave()
    {
        red = GameObject.Find("Red");
        red.transform.Translate(Vector3.up); 

    }


}
