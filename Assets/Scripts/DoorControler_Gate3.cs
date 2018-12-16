using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControler_Gate3 : MonoBehaviour {

    public GameObject door;

    public void OpensGate3()
    {
        Animator anim = door.GetComponent<Animator>();
        anim.SetTrigger("Open");
    }
    public void ClosesGate3()
    {
        Animator anim = door.GetComponent<Animator>();
        anim.SetTrigger("Close");
    }
}
