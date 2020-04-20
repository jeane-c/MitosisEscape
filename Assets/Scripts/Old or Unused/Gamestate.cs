using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamestate : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;
    public GameObject door6;



    // Start is called before the first frame update
    void Start()
    {
        door1.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door2.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door3.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door4.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door5.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door5.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown("u")){
        //     GameObject.Find("door_01").transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
        //     GameObject.Find("door_02").transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        // }

        
    }
}
