using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeTextChange : MonoBehaviour
{
    public string initialLetter = "A";
    //the correct letter for this dial to be on
    public string correctLetter = "A";

    private string[] text_states = new string[4] {"A", "T", "C", "G"};
    private int count = 0;
    private TextMesh tm;
    private SafePuzzleController spc;

    void Start()
    {
        tm = gameObject.GetComponent<TextMesh>();
        spc = gameObject.GetComponentInParent<SafePuzzleController>();

        switch (initialLetter) {
            case "A": count = 0; break;
            case "T": count = 1; break;
            case "C": count = 2; break;
            case "G": count = 3; break;
            default: break;
        }

        tm.text = text_states[count];
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;
            if (count >= text_states.Length) {
                count = 0;
            }

            tm.text = text_states[count];
            spc.checkIfCorrect();
        }
    }

    public bool isCorrect() {
        if (text_states[count] == correctLetter) {
            return true;
        }
        return false;   
    }
}
