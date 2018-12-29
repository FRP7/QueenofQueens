using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlocks_camera : MonoBehaviour {

    public Camera SecondaryCamera;
    public GameObject Hyerogliph;
    public GameObject Crosshair;

    private void Start()
    {
        SecondaryCamera.enabled = false;
    }

    public void ShowsCamera()
    {
        SecondaryCamera.enabled = true;
        Crosshair.SetActive(false);
    }
    public void HidesCamera()
    {
        SecondaryCamera.enabled = false;
        Crosshair.SetActive(true);
    }
    public void ActivateHyerogliph()
    {
        if(Hyerogliph != null)
        Hyerogliph.SetActive(true);
    }
}
