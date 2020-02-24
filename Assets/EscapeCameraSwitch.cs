using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeCameraSwitch : MonoBehaviour
{
    public GameObject Wall5;
    public GameObject Wall2;
    public GameObject TableView;
    public GameObject Wall3;
    public GameObject Wall4;
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
            TableView.SetActive(false);
            Wall3.SetActive(false);
            Wall4.SetActive(false);
        }
          if(Input.GetKeyDown("3")){
            Wall2.SetActive(true);
            Wall5.SetActive(false);
             TableView.SetActive(false);
                    Wall4.SetActive(false);
               Wall3.SetActive(false);
        }
         if(Input.GetKeyDown("4")){
            Wall2.SetActive(false);
            Wall5.SetActive(false);
             TableView.SetActive(true);
               Wall3.SetActive(false);
                      Wall4.SetActive(false);
        }
         if(Input.GetKeyDown("5")){
            Wall2.SetActive(false);
            Wall5.SetActive(false);
             TableView.SetActive(false);
               Wall3.SetActive(true);
                      Wall4.SetActive(false);
        }
             if(Input.GetKeyDown("6")){
            Wall2.SetActive(false);
            Wall5.SetActive(false);
             TableView.SetActive(false);
               Wall3.SetActive(false);
                      Wall4.SetActive(true);
        }
    }
}
