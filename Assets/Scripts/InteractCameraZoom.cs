using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCameraZoom : MonoBehaviour
{
    public Interactable[] interactablesToActivate; //which interactables should be activated when this zoom is done
    public string itemName;
    public Camera cameraToActivate; //camera to activate
    public UnzoomButton unzoom;
    
    private CameraController camController;
    private Collider coll; //the collider on this object
    //the CustomCursor in the scene; should only be one.
    private CustomCursor cc;


    // Start is called before the first frame update
    void Start() {
        camController = GameObject.Find("Cameras").GetComponent<CameraController>();
        coll = gameObject.GetComponent<Collider>();
        cc  = GameObject.Find("Cursor").GetComponent<CustomCursor>();
    }

    void OnMouseOver() {
        //Sets the cursor text to this object's name when hovered over
        cc.setCursorText(itemName);

        //On click...
        if (Input.GetMouseButtonDown(0)) {
            activateZoom();
        }
    }

    void OnMouseExit() {
        //When the mouse is no longer hovering over this object, empty the cursor text
        cc.setCursorText("");
    }

    void activateZoom() {
        for (int i = 0; i < interactablesToActivate.Length; i++) {
            if (interactablesToActivate[i] != null) {
                interactablesToActivate[i].enabled = true;
            }
        }
        coll.enabled = false;
        camController.disableCamera();
        cameraToActivate.gameObject.SetActive(true);

        unzoom.gameObject.SetActive(true);
        unzoom.setICZ(this);
    }

    public void deactivateZoom() {
        for (int i = 0; i < interactablesToActivate.Length; i++) {
            if (interactablesToActivate[i] != null) {
                interactablesToActivate[i].enabled = false;
            }
        }
        coll.enabled = true;
        camController.reEnableCurrentCamera();
        cameraToActivate.gameObject.SetActive(false);

        unzoom.gameObject.SetActive(false);
    }

    
}
