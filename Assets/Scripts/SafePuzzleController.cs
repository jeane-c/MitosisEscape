using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafePuzzleController : MonoBehaviour
{
    //animator to be used to open the safe door
    public Animator doorAnim;

    //array of all the dials
    private SafeTextChange[] dials;

    // Start is called before the first frame update
    void Start() {
        dials = gameObject.GetComponentsInChildren<SafeTextChange>();
    }

    public void checkIfCorrect() {
        bool allCorrect = true;
        
        for (int i = 0; i < dials.Length; i++) {
            if (!dials[i].isCorrect()) { allCorrect = false; }
        }

        if (allCorrect) {
            completePuzzle();
        }
    }

    //called once all dials are correct
    private void completePuzzle() {
        Debug.Log("Puzzle is correct!");
        doorAnim.SetTrigger("OpenClose");
        GameObject.Destroy(gameObject);
    }
}
