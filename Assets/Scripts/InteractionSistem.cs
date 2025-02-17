using UnityEngine;

public class InteractionSistem : MonoBehaviour
{
    public InteractItem interactItem;

    private void Start()
    {
        interactItem = GetComponent<InteractItem>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            interactItem.Interact();
        }
    }
}
