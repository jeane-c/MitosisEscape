using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleMain : MonoBehaviour
{
    //the number of puzzle flags necessary to spawn/delete objects
    public int flagsNeededToActivate = 1;
    //object to be spawned
    public GameObject objectToSpawn;
    //spawn coordinates relative to this object
    public Vector3 localSpawnCoordinates = Vector3.zero;
    //objects to be deleted
    public GameObject[] objectsToDelete;
    
    //how many flags have been activated so far
    private int flags = 0;

    public void incrementFlags() { 
        flags++; 
        if (flags >= flagsNeededToActivate) { completePuzzle(); }
    }

    private void completePuzzle() {
        Instantiate(objectToSpawn, transform.TransformPoint(localSpawnCoordinates), objectToSpawn.transform.rotation);

        for (int i = 0; i < objectsToDelete.Length; i++) {
            GameObject.Destroy(objectsToDelete[i]);
        }
    }
}
