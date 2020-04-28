using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetRotate : MonoBehaviour
{
    public GameObject m1, m2, m3, m4, m5;
    public Camera MachineCamera;
    Ray ray;
    RaycastHit hit;
     
     void Update()
     {
            if(Input.GetMouseButtonDown(0)){
                ray = MachineCamera.ScreenPointToRay(Input.mousePosition);
                 if(Physics.Raycast(ray, out hit))
                 {
                    if (hit.collider.name == "MButton1"){
                          m1.transform.Rotate(0, 180, 0, Space.World);
                        m4.transform.Rotate(0, 180, 0, Space.World);
                          m5.transform.Rotate(0, 180, 0, Space.World);
                    }
                      if (hit.collider.name == "MButton2"){
                          m2.transform.Rotate(0, 180, 0, Space.World);
                         m3.transform.Rotate(0, 180, 0, Space.World);
                    }
                     if (hit.collider.name == "MButton3"){
                          m2.transform.Rotate(0, 180, 0, Space.World);
                            m5.transform.Rotate(0, 180, 0, Space.World);
                    
                    }
                }
            }
        
     }
}
