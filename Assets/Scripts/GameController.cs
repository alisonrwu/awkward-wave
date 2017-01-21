using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;
    private int score;

	void Start () {
        score = 0;
        updateScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addScore()
    {
        score += 1;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
