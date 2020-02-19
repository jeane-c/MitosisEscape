using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeCameraSwitch : MonoBehaviour
{
    public GameObject Wall5;
    public GameObject Wall2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("1")){
            print("script works");
        }
         if(Input.GetKeyDown("2")){
            Wall5.SetActive(true);
            Wall2.SetActive(false);
        }
          if(Input.GetKeyDown("3")){
            Wall2.SetActive(true);
            Wall5.SetActive(false);
        }
    }
}
