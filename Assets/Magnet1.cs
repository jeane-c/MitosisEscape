using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet1 : MonoBehaviour
{
    public GameObject m1,m4,m5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnMouseDown(){
                m1.transform.Rotate(0, 180, 0, 0);
                        m4.transform.Rotate(0, 180, 0,0);
                          m5.transform.Rotate(0, 180, 0, 0);
    }
}
