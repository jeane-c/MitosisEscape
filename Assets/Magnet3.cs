using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet3 : MonoBehaviour
{
     public GameObject m2,m5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
                m2.transform.Rotate(0, 180, 0, Space.World);
                    m5.transform.Rotate(0, 180, 0, Space.World);
    }
}
