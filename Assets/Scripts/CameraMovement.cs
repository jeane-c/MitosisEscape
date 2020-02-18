using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float inputX, inputZ;
    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        
        if (inputX != 0)
            rotate();
        if (inputZ != 0)
            move();

      



    }
    private void rotate()
    {
        int degree = 0;
        //transform.Rotate(new Vector3(0f, degree + 90, 0f));

        transform.Rotate(new Vector3(0f, inputX * Time.deltaTime, 0f));
        //Camera.main.transform.Rotate(new Vector3(0, 90, 0));
    }

    private void move()
    {
        transform.position += transform.forward * inputZ * Time.deltaTime;
    }
}
