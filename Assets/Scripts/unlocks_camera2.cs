using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlocks_camera2 : MonoBehaviour {

    public Camera SecondaryCamera;

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
}
