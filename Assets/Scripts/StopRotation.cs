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
        if (Input.GetMouseButtonDown(0))
        {
            arrow.rotateObject = false;
            if ((arrow.rotationValue <= 360) && arrow.rotationValue >= 270) {
                Debug.Log("You are in the correct range");
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
