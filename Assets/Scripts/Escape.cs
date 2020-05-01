using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("door_01").transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        GameObject.Find("door_02").transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);

        
    }

    // Update is called once per frame
    
}
