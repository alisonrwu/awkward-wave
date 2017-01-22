using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hfButton : MonoBehaviour {

    public Button button;
    GameObject target;
    AwkwardController ac;

    void Awake()
    {
        button = GetComponent<Button>();
        ac = GetComponent<AwkwardController>();
    }
    // Use this for initialization
    void Start()
    {
        button.onClick.AddListener(() => Clicked());
    }

    void Clicked()
    {
        //Physics.gravity = new Vector3(0, 50, 0);
        target = ac.FindClosestWalker();
        if (target && ac.getCanHF() && !ac.getHappy())
        {
            target.AddComponent<Rigidbody2D>();
            target.transform.Translate(Vector3.up);
            Invoke("destroyRB", 0.45f);

            if (target.transform.Find("Tag2").gameObject.tag == "HFme")
            {
                Debug.Log("high five !");
                ac.gc.addScore(5);
                target.GetComponent<RunningLeft>().happy = true;
            }
            else if (target.transform.Find("Tag2").gameObject.tag == "WaveTo")
            {
                ac.gc.addScore(1);
                target.GetComponent<RunningLeft>().happy = true;
            }
            else
            {
                Debug.Log("awks");
                ac.lowerAwkwardHealth(); //not working?
            }
        }
    }

    private void destroyRB()
    {
        Destroy(target.GetComponent<Rigidbody2D>());
    }
}
