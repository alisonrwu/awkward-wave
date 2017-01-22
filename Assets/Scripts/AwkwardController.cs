using System.Collections;
using System.Collections.Generic;
using Image = UnityEngine.UI.Image;
using UnityEngine;

public class AwkwardController : MonoBehaviour {
    Image AwkwardBar;
    float tmpHealth;

    public GameController gc;
    public int scoreValue = 1;

    public ActionLogic sight;

	void Start () {
        //   AwkwardBar = GameObject.Find("HealthCamera").transform.FindChild("AwkCanvas").FindChild("AwkwardBar").GetComponent<Image>(); 	
        AwkwardBar = GetComponent<Image>();
        tmpHealth = 1f;

        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if(gameControllerObject != null)
        {
            gc = gameControllerObject.GetComponent<GameController>();
        }
        if(gc == null)
        {
            Debug.Log("Cannot find GameController script!");
        }

        sight = GameObject.FindGameObjectWithTag("Player").GetComponent<ActionLogic>();
    }

    void updateBar()
    {
        AwkwardBar.fillAmount = tmpHealth;
    }

    public void lowerAwkwardHealth()
    {
        tmpHealth -= 0.1f;
        updateBar();
    }

    public void waveClick()
    {
        if (sight.canWave)
        {
            gc.addScore(1);
        }
    }

    public void hfClick()
    {
        if (sight.canHF)
        {
            gc.addScore(5);
        }
    }

    public void increaseScore()
    {
        gc.addScore(1);
    }
}
