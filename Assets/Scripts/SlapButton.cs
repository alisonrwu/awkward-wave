using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SlapButton : MonoBehaviour
{
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

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) ||
            Input.GetKey("s"))
        {
            Clicked();
        }
    }

    void Clicked()
    {
        Physics.gravity = new Vector3(0, -50, 0);
        target = ac.FindClosestWalker();
        if (target && ac.getCanHF() && !ac.getHappy())
        {
            target.AddComponent<Rigidbody2D>();
            target.transform.Translate(new Vector3(2, 1, 0));
            //target.transform.Translate(Vector3.down * 2);
            target.transform.Rotate(Vector3.forward * -60);

            if (target.transform.Find("Tag2").gameObject.tag == "Angry")
            {
                Debug.Log("slapped");
                ac.gc.addScore(3);
                target.GetComponent<RunningLeft>().happy = true;
            }
            else
            {
                Debug.Log("awks");
                ac.lowerAwkwardHealth(); //not working
                target.GetComponent<RunningLeft>().happy = true;
            }
        }

    }

}
