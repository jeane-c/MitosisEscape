using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnzoomButton : MonoBehaviour {
    private InteractCameraZoom icz = null;

    public void setICZ(InteractCameraZoom newICZ) { icz = newICZ; }
    public void unzoom() { icz.deactivateZoom(); }
}
