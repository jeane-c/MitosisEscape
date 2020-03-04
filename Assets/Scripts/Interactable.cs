using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string itemName; //Object name; shown on hover.
    public string description; //Object description; shown on click if item can't be picked up. 
    public bool canBeTaken; //Whether or not the object can be picked up.
    public Item item; //The item added to the inventory when the object is picked up.
    public bool destroyWhenTaken = true; //Whether or not the gameobject will be destroyed when the item is picked up.

    //the CustomCursor in the scene; should only be one.
    private CustomCursor cc;
    private Inventory inv;

    void Start() {
        cc  = GameObject.Find("Cursor").GetComponent<CustomCursor>();
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
    }

    void OnMouseOver() {
        //Sets the cursor text to this object's name when hovered over
        cc.setCursorText(itemName);


        //On click...
        if (Input.GetMouseButtonDown(0)) {

            if (canBeTaken) { 
                TakeItem();
                //Set the description to be blank
                cc.setDescriptionText(""); 

                //if the object is destroyed when taken, destroy it. Otherwise, just make it so you can't take it again.
                if (destroyWhenTaken) {
                    cc.setCursorText("");
                    Object.Destroy(gameObject); 
                }
                else { canBeTaken = false; }
            }
            //If this object can't be taken, put the description text in the box
            else { cc.setDescriptionText(description); }
        }
    }

    void OnMouseExit() {
        //When the mouse is no longer hovering over this object, empty the cursor text
        cc.setCursorText("");

    }

    void TakeItem() {
        inv.addItem(item);
        inv.updateInventoryDisplay();
    }
}
