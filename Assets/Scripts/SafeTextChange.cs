using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeTextChange : MonoBehaviour
{
    public string[] text_states = new string[4];
    public int count = 0;

    void Start()
    {
        text_states[0] = "A";
        text_states[1] = "T";
        text_states[2] = "C";
        text_states[3] = "G";

        GetComponent<TextMesh>().text = text_states[count];
    }


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count = count + 1;
            if (count >= text_states.Length)
            {
                count = 0;
                GetComponent<TextMesh>().text = text_states[count];
            }
            else
            {
                GetComponent<TextMesh>().text = text_states[count];
            }

        }
    }
}
