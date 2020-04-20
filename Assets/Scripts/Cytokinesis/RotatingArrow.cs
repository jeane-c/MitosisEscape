using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingArrow : MonoBehaviour
{
    public bool rotateObject;
    public float rotationValue;

    void Update()
    {
        if (rotateObject) {
            rotationValue = transform.eulerAngles.x;
            transform.Rotate(new Vector3(0f, Time.deltaTime * 60, 0f));
            // transform.localRotation = Quaternion.Euler(0f, 90f, 0f);
        }
    }
}

