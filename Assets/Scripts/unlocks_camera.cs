using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlocks_camera : MonoBehaviour {

    public Camera SecondaryCamera;
    public GameObject Hyerogliph;

    private void Start()
    {
        SecondaryCamera.enabled = false;
    }

    public void ShowsCamera()
    {
        SecondaryCamera.enabled = true;
    }
    public void HidesCamera()
    {
        SecondaryCamera.enabled = false;
    }
    public void ActivateHyerogliph()
    {
        Hyerogliph.SetActive(true);
    }
}
