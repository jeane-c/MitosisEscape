using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotSelect : MonoBehaviour, IPointerClickHandler
{
    //the inventory; should also only be one
    private Inventory inv;
    public int selectID = 0;

    // Start is called before the first frame update
    void Start() {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
    }

    public void OnPointerClick(PointerEventData e) {
        inv.setSelectedItemIndex(selectID);
        Debug.Log("Clicked item slot " + selectID);
    }
}
