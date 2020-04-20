using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleFlagUpdate : MonoBehaviour
{
     //id for the item that is to be used on this object
    public PuzzleFlag flag; //flag to activate when object is used
    
    private bool activatedYet = false;

    public bool useItem(Item incomingItem) {
        if (activatedYet) { return false; }

        //change this if statement to do with spinner

        if (Input.GetKeyDown("z")) {
            flag.enableFlag();
            activatedYet = true;
            return true;
        }
        return false;
    }
}
