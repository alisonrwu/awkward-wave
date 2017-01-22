using System.Collections;
using System.Collections.Generic;
using Image = UnityEngine.UI.Image;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AwkwardController : MonoBehaviour {
    Image AwkwardBar;
    float tmpHealth;

    public GameController gc;
    public int scoreValue = 1;

    public GameObject self;
    public ActionLogic sight;
    public RunningLeft walker;

    void Awake()
    {
        self = GameObject.FindGameObjectWithTag("Player");
    }

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

        sight = self.GetComponent<ActionLogic>();
    }

    void Update()
    {
        //Debug.Log("update");
        if(walker == null || walker.happy)
        {
            //Debug.Log("found closest walker");
            walker = FindClosestWalker().GetComponent<RunningLeft>();
        }
    }

    void updateBar()
    {
        AwkwardBar.fillAmount = tmpHealth;
    }

    public void lowerAwkwardHealth()
    {
        if (tmpHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            tmpHealth -= 0.1f;
            updateBar();
        }
    }

    public void waveClick()
    {
        Debug.Log("Wave!");
        if (sight.canWave && !walker.happy)
        {
            Debug.Log("Wave! because you're unhappy");
            gc.addScore(1);
            walker.happy = true;
        }
    }

    public void hfClick()
    {
        Debug.Log("HighFive!");
        if (sight.canHF && !walker.happy)
        {
            Debug.Log("HighFive! because you're unhappy");
            gc.addScore(5);
            walker.happy = true;
        }
    }

    public void slapClick()
    {
        if (sight.canHF && !walker.happy)
        {
            gc.addScore(8);
            walker.happy = true;
        }
    }

    // Find the name of the closest walker
    GameObject FindClosestWalker()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Walker");
        //Debug.Log(gos[0]);
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = self.transform.position;
        foreach (GameObject go in gos)
        {
            if (go.GetComponent<RunningLeft>().happy)
            {//if already happy get the next walker
                break;
            }
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

}
