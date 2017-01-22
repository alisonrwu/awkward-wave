using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SlapButton : MonoBehaviour
{
    private Button button;
    public GameObject angry;

    //public AwkwardController ac;

    void Awake()
    {
        button = GetComponent<Button>();
    }
    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(() => Clicked());
    }

    void Clicked()
    {
        angry = GameObject.FindGameObjectWithTag("Angry").transform.parent.gameObject;
        if (angry = GameObject.FindGameObjectWithTag("Angry").transform.parent.gameObject)
        {
            angry.transform.Translate(Vector3.down);
            //ac.increaseScore();
        }
        else
        {
            //ac.lowerAwkwardHealth();
        }

    }

}
