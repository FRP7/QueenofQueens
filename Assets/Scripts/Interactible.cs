using UnityEngine;

public class Interactible : MonoBehaviour
{
    public bool isInteractive;
    public bool isActive;
    public bool isPickable;
    public bool allowsPlacement;
    public bool allowsMultipleInteractions;
    public bool isRotatable;
    public string requirementText;
    public string interactionText;
    public bool consumesRequirements;
    public Interactible[] inventoryRequirements;
    public Interactible[] indirectInteractibles;
    public Interactible[] indirectActivations;
    public int rotations;

    public void Activate()
    {
        isActive = true;

        PlayActivateAnimation();
    } 

    public void Interact()
    {
        
            PlacePlaceables();

            PlayInteractAnimation();

        if (isActive)
        {

            InteractIndirects();

            ActivateIndirects();

            if (!allowsMultipleInteractions)
                isInteractive = false;
        }
    }

    private void PlayActivateAnimation()
    {
        Animator animator = GetComponent<Animator>();

        if (animator != null)
            animator.SetTrigger("Activate");
    }

    private void PlayInteractAnimation()
    {
        if (!isRotatable)
        {
            Animator animator = GetComponent<Animator>();

            if (animator != null)
                animator.SetTrigger("Interact");
        }
    }

    private void InteractIndirects()
    {
        if (!isRotatable)
        {
            if (indirectInteractibles != null)
            {
                for (int i = 0; i < indirectInteractibles.Length; ++i)
                    indirectInteractibles[i].Interact();
            }
        } else
            if (indirectInteractibles != null)
        {
            for (int i = 0; i < indirectInteractibles.Length; ++i)
                indirectInteractibles[i].Rotate();
        }

    }

    private void ActivateIndirects()
    {
        if (indirectActivations != null)
        {
            for (int i = 0; i < indirectActivations.Length; ++i)
                indirectActivations[i].Activate();
        }
    }

    private void PlacePlaceables()
    {
        if (allowsPlacement)
        {
            if (indirectInteractibles != null)
            {
                for (int i = 0; i < indirectInteractibles.Length; ++i)
                    indirectInteractibles[i].gameObject.SetActive(true);
            }
        }
    }
  
    private void Rotate()
    {
        if (isRotatable)
        {
            if(Input.GetKeyDown(KeyCode.F)) rotations += 1;
            Animator animator = GetComponent<Animator>();
            if (rotations == 9) rotations = 1;

            switch (rotations)
            {
                case 1 :
                    animator.SetTrigger("rotate45");
                    break;
                case 2:
                    animator.SetTrigger("rotate90");
                    break;
                case 3:
                    animator.SetTrigger("rotate135");
                    break;
                case 4:
                    animator.SetTrigger("rotate180");
                    break;
                case 5:
                    animator.SetTrigger("rotate225");
                    break;
                case 6:
                    animator.SetTrigger("rotate270");
                    break;
                case 7:
                    animator.SetTrigger("rotate315");
                    break;
                case 8:
                    animator.SetTrigger("rotate360");
                    break;
            }

        }
    }


}
