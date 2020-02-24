using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeCameraSwitch : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
     public GameObject Cam5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("1")){
           Cam1.SetActive(true);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
               Cam5.SetActive(false);
        }
         if(Input.GetKeyDown("2")){
           
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            Cam3.SetActive(false);
            Cam4.SetActive(false);
               Cam5.SetActive(false);
        }
          if(Input.GetKeyDown("3")){
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(true);
             Cam4.SetActive(false);
                Cam5.SetActive(false);
          
        }
         if(Input.GetKeyDown("4")){
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
             Cam4.SetActive(true);
              Cam5.SetActive(false);
            
        }
         if(Input.GetKeyDown("5")){
           Cam1.SetActive(false);
            Cam2.SetActive(false);
            Cam3.SetActive(false);
             Cam4.SetActive(false);
             Cam5.SetActive(true);
            
        }
             if(Input.GetKeyDown("6")){
            
            
        }
    }
}
