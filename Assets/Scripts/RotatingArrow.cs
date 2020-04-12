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
            transform.Rotate(new Vector3(0f, Time.deltaTime * 100, 0f));
          //  if (rotationValue >= 360) {
               // rotationValue = 0; 
          //  } else { 
         //      // rotationValue += Time.deltaTime * 1000;
           // }

        }
    }
}

