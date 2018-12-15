using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxInteractionDistance;
    public int   inventorySize;

    private CanvasManager       _canvasManager;
    private Camera              _camera;
    private RaycastHit          _raycastHit;
    private Interactible        _currentInteractible;
    private List<Interactible>  _inventory;
    public Interactible[] OpenDoorsCheat;
    
    private void Start()
    {
        _canvasManager = CanvasManager.instance;

        _camera = GetComponentInChildren<Camera>();

        _currentInteractible = null;

        _inventory = new List<Interactible>(inventorySize);
    }

    void Update()
    {
        CheckForInteractible();
        CheckForInteractionClick();
    }

    private void CheckForInteractible()
    {
        if (Physics.Raycast(_camera.transform.position,
            _camera.transform.forward, out _raycastHit,
            maxInteractionDistance))
        {
            Interactible newInteractible = _raycastHit.collider.GetComponent<Interactible>();

            if (newInteractible != null && newInteractible.isInteractive)
                SetInteractible(newInteractible);
            else
                ClearInteractible();
        }
        else
            ClearInteractible();
    }

    private void CheckForInteractionClick()
    {
        if (Input.GetKey(KeyCode.F) && _currentInteractible != null)
        {
            if (_currentInteractible.isPickable)
            {
                _currentInteractible.Interact();
                AddToInventory(_currentInteractible);
            }
            else if (HasRequirements(_currentInteractible))
                Interact(_currentInteractible);
        }
        if(Input.GetKey(KeyCode.P))
        {
            for (int i = 0; i < OpenDoorsCheat.Length; ++i)
                OpenDoorsCheat[i].Interact();
        }
    }

    private void SetInteractible(Interactible newInteractible)
    {
        _currentInteractible = newInteractible;

        if (HasAtLeastOneRequirement(_currentInteractible)) _currentInteractible.requirementText = "We need more of those Hieroglyphs!";

        if (HasRequirements(_currentInteractible))
            _canvasManager.ShowInteractionPanel(_currentInteractible.interactionText);
        else
            _canvasManager.ShowInteractionPanel(_currentInteractible.requirementText);
    }

    private void ClearInteractible()
    {
        _currentInteractible = null;

        _canvasManager.HideInteractionPanel();
    }
    private bool HasAtLeastOneRequirement(Interactible interactible)
    {
        for (int i = 0; i < interactible.inventoryRequirements.Length; ++i)
            if (HasInInventory(interactible.inventoryRequirements[i]))
                return true;
        return false;
    }
    private bool HasRequirements(Interactible interactible)
    {
        for (int i = 0; i < interactible.inventoryRequirements.Length; ++i)
            if (!HasInInventory(interactible.inventoryRequirements[i]))
                return false;

        return true;
    }

    private void Interact(Interactible interactible)
    {
        if (interactible.consumesRequirements)
        {
            for (int i = 0; i < interactible.inventoryRequirements.Length; ++i)
                RemoveFromInventory(interactible.inventoryRequirements[i]);
        }

        interactible.Interact();
    }

    private void AddToInventory(Interactible pickable)
    {
        if (_inventory.Count < inventorySize)
        {
            _inventory.Add(pickable);
            pickable.gameObject.SetActive(false);
            Debug.Log("Adds objects to inventory");
        }
    }

    private bool HasInInventory(Interactible pickable)
    {
        return _inventory.Contains(pickable);
    }

    private void RemoveFromInventory(Interactible pickable)
    {
        _inventory.Remove(pickable);
        Debug.Log("Uses the object");
    }

}
