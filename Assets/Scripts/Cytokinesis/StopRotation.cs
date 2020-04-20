using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRotation : MonoBehaviour
{
    public RotatingArrow arrow;
    public float maxRotationValue;
    public float minRotationValue;
    public bool completed = false;

    void Start()
    {
        arrow = GetComponentInChildren<RotatingArrow>();
        arrow.rotateObject = true;
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            arrow.rotateObject = false;
            if ((arrow.rotationValue <= maxRotationValue) && arrow.rotationValue >= minRotationValue) {
                Debug.Log("You are in the correct range");
                completed = true;
            } else {
                Debug.Log("you are in the wrong range");
                StartCoroutine(ExampleCoroutine());
            }

        }
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);

        arrow.rotateObject = true;
    }

}
