using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomCursor : MonoBehaviour
{
    //NOTE: Must be attached to an object named "Cursor"!

    //The text UI object attached to the cursor.
    private Text cursorText;
    private Text descriptionText;

    void Start() {
        Cursor.visible = false;
        cursorText = GetComponentInChildren<Text>();
        cursorText.text = "";
        descriptionText = GameObject.Find("Description").GetComponent<Text>();
    }

    void Update() {
        //Cursor image follows real mouse position.
        transform.position = Input.mousePosition;
    }

    public void setCursorText(string t) {
        cursorText.text = t;
    }

    public void setDescriptionText(string t) {
        descriptionText.text = t;
    }
}
