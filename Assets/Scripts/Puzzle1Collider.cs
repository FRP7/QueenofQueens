using UnityEngine;


public class Puzzle1Collider : MonoBehaviour


{
    bool CollidingOuter = false;
    bool CollidingInner = false;
    public GameObject Animates;

    private void Update()
    {
        CheckForBothCollisions();
    }
    public void OnTriggerEnter(Collider col1)
    {
        if (col1.gameObject.name == "ColliderInner")
        {
            CollidingInner = true;
            Debug.Log("Inner collision");
        }
        if (col1.gameObject.name == "ColliderOuter")
        {
            CollidingOuter = true;
            Debug.Log("Outer collision");
        }
    }

    public void OnTriggerExit(Collider col1)
    {
        if (col1.gameObject.name == "ColliderInner")
        {
            CollidingInner = false;
            Debug.Log("Inner collision");
        }
        if (col1.gameObject.name == "ColliderOuter")
        {
            CollidingOuter = false;
            Debug.Log("Outer collision");
        }
    }

    private void CheckForBothCollisions()
    {
        if (CollidingInner == true && CollidingOuter == true)
        {
            Animator anim = Animates.GetComponent<Animator>();
            anim.SetTrigger("Interact");
            
        }
    }
   
}