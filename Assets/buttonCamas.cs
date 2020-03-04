using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonCamas : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject Cam4;
    public GameObject Cam5;
    public GameObject DeskView;
    public GameObject ClipBoard;
    GameObject[] Cams = new GameObject[7];


    public int count = 0;
    public int max = 7;
    public int min = 0;
    // Start is called before the first frame update
    void Start()
    {
    Cams[0] = Cam1;
    Cams[1] = Cam2;
    Cams[2] = Cam3;
    Cams[3] = Cam4;
    Cams[4] = Cam5;
    Cams[5] = DeskView;
    Cams[6] = ClipBoard;
   

    Cam1.SetActive(true);
    Cam2.SetActive(false);
    Cam3.SetActive(false);
    Cam4.SetActive(false);
    Cam5.SetActive(false);
    DeskView.SetActive(false);
    ClipBoard.SetActive(false);
    }

 public void ChangeCameraLeft(){
       
    
        for(int i = 0; i < Cams.Length; i++){
              
            if(Cams[i].activeSelf == true){
           count = i;
             print(i);
        
              }

         }
        count = count - 1;
           for(int i = 0; i < Cams.Length; i++){
               if(i >= 0 && i < Cams.Length){
                    if(i != count){
                   Cams[i].SetActive(false);
               }
               if(i == count){
                   Cams[i].SetActive(true);
               }
               }
               
           }
    }
    public void ChangeCameraRight(){
       
    
        for(int i = 0; i < Cams.Length; i++){
              
            if(Cams[i].activeSelf == true){
           count = i;
             print(i);
        
              }

         }
        count = count + 1;
           for(int i = 0; i < Cams.Length; i++){
             if(i >= 0 && i < Cams.Length){
                    if(i != count){
                   Cams[i].SetActive(false);
               }
               if(i == count){
                   Cams[i].SetActive(true);
               }
               }
           }
    }
    // Update is called once per frame
    void Update()
    {
        
       
    }
}
