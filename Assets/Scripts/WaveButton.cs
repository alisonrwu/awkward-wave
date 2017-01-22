using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveButton : MonoBehaviour {

    public Button button;
    GameObject target;
    AwkwardController ac;

    void Awake()
    {
        button = GetComponent<Button>();
        ac = GetComponent<AwkwardController>();

    }

    // Use this for initialization
    void Start () {
        button.onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        Debug.Log("Hello");
        wave(); 
    }

    public void wave()
    {
        

    }


}
