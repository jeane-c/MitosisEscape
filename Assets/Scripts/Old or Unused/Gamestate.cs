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

    public GameObject cell1;
    public GameObject cell2;
    public GameObject cell3;
    public GameObject cell4;
    public GameObject cell5;


    // Start is called before the first frame update
    void Start()
    {
        stage = 0;
        Debug.Log("hell");
        print("huh");
        door1.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door2.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door3.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door4.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;
        door5.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("y")&&stage==0){
            stage = 1;
            print("made it");
            //door1.transform.position = new Vector3(-1.5f, 1.3f, 1.0f);
            door1.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = true;
            door1.transform.GetComponentInChildren<TextMesh>().color =Color.green;
            door2.transform.GetComponentInChildren<TextMesh>().color =Color.red;
            cell1.SetActive(false);
            cell2.SetActive(true);

            //door1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }else if(Input.GetKeyDown("y")&&stage==1){
            stage = 2;
            print("made it "+stage);
            //door1.transform.position = new Vector3(-1.5f, 1.3f, 1.0f);
            door2.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = true;
            door2.transform.GetComponentInChildren<TextMesh>().color =Color.green;
            cell2.SetActive(false);
            cell3.SetActive(true);
            //door1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }else if(Input.GetKeyDown("y")&&stage==2){
            stage = 3;
            print("made it "+stage);
            //door1.transform.position = new Vector3(-1.5f, 1.3f, 1.0f);
            door3.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = true;
            door3.transform.GetComponentInChildren<TextMesh>().color =Color.green;
            cell3.SetActive(false);
            cell4.SetActive(true);
            //door1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }else if(Input.GetKeyDown("y")&&stage==3){
            stage = 4;
            print("made it "+stage);
            //door1.transform.position = new Vector3(-1.5f, 1.3f, 1.0f);
            door4.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = true;
            door4.transform.GetComponentInChildren<TextMesh>().color =Color.green;
            
            //door1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }else if(Input.GetKeyDown("y")&&stage==4){
            stage = 5;
            print("made it "+stage);
            //door1.transform.position = new Vector3(-1.5f, 1.3f, 1.0f);
            door5.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = true;
            door5.transform.GetComponentInChildren<TextMesh>().color =Color.green;
            cell4.SetActive(false);
            cell5.SetActive(true);
            //door1.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }

        if(Input.GetKeyDown("u")){
            GameObject.Find("door_01").transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            GameObject.Find("door_02").transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }

        
    }
}
