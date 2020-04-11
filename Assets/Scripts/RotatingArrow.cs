using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingArrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public bool rotateObject; 

    void Update()
    {
        if (rotateObject) { 
            transform.Rotate(new Vector3(0f, Time.deltaTime * 500, 0f));
        } else
        {
            Debug.Log("stop please");
        }
    }
}

