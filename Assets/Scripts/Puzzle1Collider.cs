using UnityEngine;


public class Puzzle1Collider : MonoBehaviour


{
    bool CollidingOuter = false;
    bool CollidingInner = false;
    bool BothColliding = false;
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

    public void CheckForBothCollisions()
    {
        if (CollidingInner == true && CollidingOuter == true)
        {
            BothColliding = true;
            Animator anim = Animates.GetComponent<Animator>();
            anim.SetTrigger("Interact");
        }
    }
}