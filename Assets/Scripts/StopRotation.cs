using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRotation : MonoBehaviour
{
    public RotatingArrow arrow;

    void Start()
    {
        arrow = GetComponentInChildren<RotatingArrow>();
        arrow.rotateObject = true;
    }


    void OnMouseOver()
    {
        Debug.Log("hovering");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("is this working?");
            arrow.rotateObject = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
