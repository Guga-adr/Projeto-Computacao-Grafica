using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactRange = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) {
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray) {
                if(collider.TryGetComponent(out NPCInteractable npcInteractable)) {
                    npcInteractable.Interact();
                }
            }
        }
    }

    public NPCInteractable GetInteractableObject() {
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray) {
            if(collider.TryGetComponent(out NPCInteractable npcInteractable)) {
                return npcInteractable;
            }
        }
        return null;
    }
}