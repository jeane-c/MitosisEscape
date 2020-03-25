using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamestate : MonoBehaviour
{
    private int stage;
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;
    public GameObject door6;

    // Start is called before the first frame update
    void Start()
    {
        stage = 0;
        Debug.Log("hell");
        print("huh");
        door1.GetComponent<DrawerOpenClose>().GetComponent<Animator>().enabled = false;
        door2.GetComponent<DrawerOpenClose>().GetComponent<Animator>().enabled = false;
        door3.GetComponent<DrawerOpenClose>().GetComponent<Animator>().enabled = false;
        door4.GetComponent<DrawerOpenClose>().GetComponent<Animator>().enabled = false;
        door5.GetComponent<DrawerOpenClose>().GetComponent<Animator>().enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("y")){
            stage = 1;
            print("made it");
            //door1.transform.position = new Vector3(-1.5f, 1.3f, 1.0f);
            door1.GetComponent<DrawerOpenClose>().GetComponent<Animator>().enabled = true;
            door1.transform.GetComponentInChildren<TextMesh>().color =Color.green;
            door2.transform.GetComponentInChildren<TextMesh>().color =Color.red;
            //door1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }else if(Input.GetKeyDown("y")&&stage==1){
            stage = 2;
            print("made it "+stage);
            //door1.transform.position = new Vector3(-1.5f, 1.3f, 1.0f);
            door2.GetComponent<DrawerOpenClose>().GetComponent<Animator>().enabled = true;
            door2.transform.GetComponentInChildren<TextMesh>().color =Color.green;
            //door1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }

        if(Input.GetKeyDown("u")){
            GameObject.Find("door_01").transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            GameObject.Find("door_02").transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }

        
    }
}
