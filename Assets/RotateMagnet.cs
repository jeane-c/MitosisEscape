using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateMagnet : MonoBehaviour
{

    public GameObject m1, m2, m3, m4, m5;
    public GameObject button1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("1")){     
              m1.transform.Rotate(0, 180, 0, Space.World);
        }
         if(Input.GetKeyDown("2")){     
              m2.transform.Rotate(0, 180, 0, Space.World);
        }
         if(Input.GetKeyDown("3")){     
              m3.transform.Rotate(0, 180, 0, Space.World);
        }
         if(Input.GetKeyDown("4")){     
              m4.transform.Rotate(0, 180, 0, Space.World);
         }
         if(Input.GetKeyDown("5")){     
              m5.transform.Rotate(0, 180, 0, Space.World);
        }

    }

    
       void RotateMagnets(){
       
    }

}
