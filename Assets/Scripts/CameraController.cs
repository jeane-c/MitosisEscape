using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //array of all cameras to cycle through; should be sorted left to right
    public Camera[] cameraArray;
    public GameObject leftButton;
    public GameObject rightButton;

    //last camera that was used
    [SerializeField] private int currentCam = 0;

    public void Start (){
        switchToCamera(currentCam);
    }

    public void switchToCamera(int index) {
        //if index is within range
        if (!(index >= cameraArray.Length && index < 0)) {
            currentCam = index; //make sure currentcam stays synced

            for (int i = 0; i < cameraArray.Length; i++) {
                if (i == index) cameraArray[i].gameObject.SetActive(true); //enable the camera if it's the one we want
                else cameraArray[i].gameObject.SetActive(false);
            }
        }
    }

    public void rotateRight () {
        currentCam++;
        if (currentCam >= cameraArray.Length) { currentCam = 0; }

        switchToCamera(currentCam);
    }

    public void rotateLeft () {
        currentCam--;
        if (currentCam < 0) { currentCam = cameraArray.Length-1; }
        switchToCamera(currentCam);
    }

    public void disableCamera() {
        cameraArray[currentCam].gameObject.SetActive(false);
        leftButton.SetActive(false);
        rightButton.SetActive(false);
    }

    public void reEnableCurrentCamera() {
        cameraArray[currentCam].gameObject.SetActive(true);
        leftButton.SetActive(true);
        rightButton.SetActive(true);
    }

    
}
