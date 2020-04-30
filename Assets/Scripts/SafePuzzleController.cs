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
        dials[0].transform.GetComponentInChildren<TextMesh>().color = Color.green;
        dials[1].transform.GetComponentInChildren<TextMesh>().color = Color.green;
        dials[2].transform.GetComponentInChildren<TextMesh>().color = Color.green;
        dials[3].transform.GetComponentInChildren<TextMesh>().color = Color.green;
        dials[4].transform.GetComponentInChildren<TextMesh>().color = Color.green;
        dials[5].transform.GetComponentInChildren<TextMesh>().color = Color.green;

        StartCoroutine(ExampleCoroutine());
    }

    // Pause for a second before opening
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        doorAnim.SetTrigger("OpenClose");
        GameObject.Destroy(gameObject);
    }

}
