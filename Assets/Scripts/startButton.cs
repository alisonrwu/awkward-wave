﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour {
    public Button button;
    public string sceneName; 

    // Use this for initialization
    void Awake()
    {
        button = GetComponent<Button>();
    }
    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(() => Clicked());
    }

	// Update is called once per frame
	void Update () {
		
	}

    void Clicked() {
        SceneManager.LoadScene("Tutorial");
    }

    void ClickedScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }



}
