using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageUpdate : MonoBehaviour
{
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        door.GetComponent<DoorOpenClose>().GetComponent<Animator>().enabled = true;
        door.transform.GetComponentInChildren<TextMesh>().color =Color.green;
    }

}
