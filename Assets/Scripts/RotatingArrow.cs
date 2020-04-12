using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingArrow : MonoBehaviour
{
    public bool rotateObject;
    public float rotationValue;

    void Start()
    {
    }


    void Update()
    {
        if (rotateObject) {
            rotationValue = this.transform.localRotation.eulerAngles.x;
            transform.Rotate(new Vector3(0f, Time.deltaTime * 10, 0f));
        }
    }
}

