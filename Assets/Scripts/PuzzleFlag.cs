using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleFlag : MonoBehaviour
{
    //the puzzle this flag corresponds to
    public PuzzleMain puzzle;
    //ensure that this flag can't be activated twice
    private bool activated = false;

    public void enableFlag() { 
        if (activated) { return; }

        puzzle.incrementFlags();
        activated = true;
    }

    public bool hasBeenActivated() { return activated; }
}
