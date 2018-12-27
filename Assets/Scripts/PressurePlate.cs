using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    public GameObject Unlocks;

    public void OnTriggerEnter(Collider col1)
    {
        Animator animator = GetComponent<Animator>();
        if (col1.gameObject.name == "Player")
        {
            Debug.Log("Enters Plate");
            animator.SetTrigger("PlateDown");
        }

    }
    public void OnTriggerExit(Collider col1)
    {
        Animator animator = GetComponent<Animator>();
        if (col1.gameObject.name == "Player")
        {
            Debug.Log("Exits Plate");
            animator.SetTrigger("PlateUp");
        }

    }

    public void showsBrick()
    {
        Animator animator = Unlocks.GetComponent<Animator>();
        animator.SetTrigger("ShowBrick");
    }

    public void hidesBrick()
    {
        Animator animator = Unlocks.GetComponent<Animator>();
        animator.SetTrigger("HideBrick");
    }
}
