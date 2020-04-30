using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFullMagnet : MonoBehaviour
{
    public GameObject m1,m2,m3,m4,m5;
    //the number of puzzle flags necessary to spawn/delete objects
    
    //object to be spawned
    public GameObject objectToSpawn;
    //spawn coordinates relative to this object
    public Vector3 localSpawnCoordinates = Vector3.zero;
    //objects to be deleted
    public GameObject[] objectsToDelete;
    public int angel1, angel2, angel3, angel4,angel5;
    private bool check = true;
    
    void Update(){
         

      angel1 = (int)m1.transform.localEulerAngles[1];
    angel2 =  (int)m2.transform.localEulerAngles[1];
    angel3 =  (int)m3.transform.localEulerAngles[1];
      angel4 =  (int)m4.transform.localEulerAngles[1];
        angel5 = (int) m5.transform.localEulerAngles[1];
        
        
       
        if(angel1 == 180 && angel2 == 180 && angel3 == 180 && angel4 == 180 && angel5 == 180 && check){
            check = false;
            spawnMagnet();
        }

    }


    private void spawnMagnet() {
        check = false;
        GameObject newObject = Instantiate(objectToSpawn, transform.TransformPoint(localSpawnCoordinates), objectToSpawn.transform.rotation);
        newObject.transform.localScale = new Vector3(1.5f, 1.3f, 1.5f);

          Destroy(gameObject);
        
    }
}
// for (int i = 0; i < objectsToDelete.Length; i++) {
        //     Object.Destroy(gameObject);
        // }