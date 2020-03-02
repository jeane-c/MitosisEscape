using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleItem : MonoBehaviour
{
    //id for the item that is to be used on this object
    public int puzzleItemID;
    public PuzzleFlag flag; //flag to activate when object is used

    public bool useItem(Item incomingItem) {
        if (incomingItem.id == puzzleItemID) {
            flag.enableFlag();
            return true;
        }
        return false;
    }
}
