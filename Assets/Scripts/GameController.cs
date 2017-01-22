using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoreText;
    private int score;

	void Start ()
    {
        score = 0;
        updateScore();
	}

    public void addScore(int i)
    {
        score += i;
        updateScore();
    }

    void updateScore()
    {
        scoreText.text = "Score: " + score;
    }

}