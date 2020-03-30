using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleItem : MonoBehaviour
{
    //id for the item that is to be used on this object
    public int puzzleItemID;
    public PuzzleFlag flag; //flag to activate when object is used
    
    private bool activatedYet = false;

    public bool useItem(Item incomingItem) {
        if (activatedYet) { return false; }

        if (incomingItem.id == puzzleItemID) {
            flag.enableFlag();
            activatedYet = true;
            return true;
        }
        return false;
    }
}
