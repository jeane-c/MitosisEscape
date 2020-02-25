using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //the actual list; using Lists instead of Arrays because size must be dynamic 
    public List<Item> inventory = new List<Item>();
    private List<Image> inventorySlotUIs;
    private int displayOffset = 0;

    public Sprite blank;

    public void Start() {
        inventorySlotUIs = new List<Image>(inventory.Capacity);

        //iterates through as many inventory slots as we initially set, and grabs the UI for each one
        for (int i = 1; i <= inventory.Capacity; i++) {
            GameObject obj = GameObject.Find("Item Frame (" + i + ")");

            //then puts it into our array
            if (obj != null) {
                inventorySlotUIs.Add(obj.transform.GetChild(0).GetComponentInChildren<Image>());
            }
        }

        updateInventoryDisplay();
    }

    public void addItem(Item newItem) {
        for (int i = 0; i < inventory.Capacity; i++) {
            if (inventory[i] == null) { inventory[i] = newItem; return; }
        }
        inventory.Add(newItem);
    }

    public void removeItemByIndex(int index) {
        inventory.RemoveAt(index);
    }

    public void removeItemByID(int ID) {
        int index = inventory.FindIndex(item => item.id == ID);
        removeItemByIndex(index);
    }

    public void updateInventoryDisplay() {

        //offset is used to scroll through inventory
        for (int i = displayOffset; i < inventorySlotUIs.Count; i++) {
            if (inventory[i] != null) {
                inventorySlotUIs[i].sprite = inventory[i].icon;
            }
            else {
                inventorySlotUIs[i].sprite = blank;
            }
        }
    }
}
