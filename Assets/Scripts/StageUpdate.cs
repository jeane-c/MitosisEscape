using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageUpdate : MonoBehaviour
{
    public GameObject door;
    public string doorName;

    // Start is called before the first frame update
    void Start()
    {
        if (door == null) { door = GameObject.Find(doorName); }

        door.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = true;
        door.transform.GetComponentInChildren<TextMesh>().color =Color.green;
    }

}
