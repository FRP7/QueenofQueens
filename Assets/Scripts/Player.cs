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
    public List<Interactible>  _inventory;
    public Interactible[] OpenDoorsCheat;
    public Interactible heart;
    public Interactible pickableHeart;
    public Interactible balance;
    public Interactible jewel;
	public Interactible PegaPickable;
	public Interactible MeioPickable;
	public Interactible LaminaPickable;
    public int itemsRequiredInInv;

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
        if (Input.GetKeyDown(KeyCode.F) && _currentInteractible != null)
        {

            if (_currentInteractible.isPickable)
            {
                _currentInteractible.Interact();
                AddToInventory(_currentInteractible);
            }
            else if (HasRequirements(_currentInteractible))
            {
                
                Interact(_currentInteractible);
            }
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
        if (_currentInteractible.tag == "Teacher")
        {
            if (HasAtLeastOneRequirement(_currentInteractible)) {
                _currentInteractible.requirementText = "Bring me more Hieroglyphs !";
            }
        }
        if (_currentInteractible.tag == "Puzzle2")
        {
            if (HasInInventory(pickableHeart)) _currentInteractible.interactionText = "Place Heart of Osiris";
        }

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
    private bool HasLengthMinuesOne(Interactible interactible)
    {

        for (int i = 0; i < interactible.inventoryRequirements.Length; ++i)
            if (HasInInventory(interactible.inventoryRequirements[i]))
            {
                itemsRequiredInInv++;
                if( interactible.inventoryRequirements.Length - 1 == itemsRequiredInInv)
                return true;
            }
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

            if (_currentInteractible.State == 1)
            {
                heart.gameObject.SetActive(true);
                heart.isInteractive = false;
                AddToInventory(jewel);
            }
            else
                jewel.gameObject.SetActive(true);

        }

        interactible.Interact();

    }

    public void AddToInventory(Interactible pickable)
    {
        if (_inventory.Count < inventorySize)
        {
            _inventory.Add(pickable);
            pickable.gameObject.SetActive(false);
            Debug.Log("Adds objects to inventory");
        }
        if (pickable == pickableHeart)
        {
            balance.State = 1;
        }
		if(pickable == PegaPickable)
		{
			Debug.Log("Pegaste na pega!");
		}
		if(pickable == MeioPickable)
		{
			Debug.Log("Pegaste no meio!");
		}
		if(pickable == LaminaPickable)
		{
			Debug.Log("Pegaste na lamina!");
		}
    }

    public bool HasInInventory(Interactible pickable)
    {
        return _inventory.Contains(pickable);
    }

    private void RemoveFromInventory(Interactible pickable)
    {
        _inventory.Remove(pickable);
        Debug.Log("Uses the object");
    }

}
