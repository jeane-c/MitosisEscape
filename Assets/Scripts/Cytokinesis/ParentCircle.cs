using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCircle : MonoBehaviour
{
    public StopRotation circle;
    // public GameObject circle2;
    // public GameObject circle3;
    // public GameObject circle4;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(circle, new Vector3(i * .5F, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
