using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string itemName = ""; //Object name; shown on hover.
    public string description = ""; //Object description; shown on click if item can't be picked up. 
    public bool canBeTaken; //Whether or not the object can be picked up.
    public Item item; //The item added to the inventory when the object is picked up.
    public bool destroyWhenTaken = true; //Whether or not the gameobject will be destroyed when the item is picked up.
    //the CustomCursor in the scene; should only be one.
    private CustomCursor cc;
    //the inventory; should also only be one
    private Inventory inv;
    //array of any PuzzleItem scripts on this object
    private PuzzleItem[] puzzles;


    void Start() {
        cc  = GameObject.Find("Cursor").GetComponent<CustomCursor>();
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        puzzles = gameObject.GetComponents<PuzzleItem>();
    }

    void OnMouseOver() {
        //prevents a weird bug with Unity
        if (this.enabled) {
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
                //if the user is trying to use an item on this object
                else if (inv.getSelectedItem() != null) {
                    //if this interactable has no puzzles on it, then deselect the item and change description accordingly
                    if (puzzles == null) {
                        inv.deselectItem();
                        cc.setDescriptionText("I can't use that here.");
                    }
                    else {
                        //check any puzzles on this object; if this item works with one of them, then end and move. Otherwise, set description accordingly. 
                        bool worked = false;
                        for (int i = 0; i < puzzles.Length; i++) {
                            if (puzzles[i].useItem(inv.getSelectedItem())) { 
                                worked = true; 
                                break; 
                            }
                        }

                        if (!worked) { 
                            inv.deselectItem(); 
                            cc.setDescriptionText("I can't use that here."); 
                        }
                        else {
                            if(inv.getSelectedItem().textonuse==""){
                                cc.setDescriptionText("I used the "+ inv.getSelectedItem().itemName + "!");
                            }else{
                                cc.setDescriptionText(inv.getSelectedItem().textonuse);
                            }
                            inv.expendItem();
                        }
                    }
                }
                //If this object can't be taken, put the description text in the box
                else { if (description != "") cc.setDescriptionText(description); }
            }
        }
    }

    void OnMouseExit() {
        //prevents a weird bug with Unity
        if (this.enabled) {
            //When the mouse is no longer hovering over this object, empty the cursor text
            cc.setCursorText("");
        }
    }

    void TakeItem() {
        inv.addItem(item);
        inv.updateInventoryDisplay();
    }
}
