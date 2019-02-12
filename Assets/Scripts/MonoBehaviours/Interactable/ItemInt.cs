using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInt : Interactable
{
    public Inventory inventory;
    private Item i;

    private void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        i = Item.CreateInstance(this.GetComponent<SpriteRenderer>().sprite);
      //  OnInteract += Interact;
    }

    override public void Interact()
    {
        if (trigger)
        {
           
            inventory.AddItem(i);
            InteractionEvent.InteractionStart(this);
            this.gameObject.SetActive(false);
            
            // Destroy(this.gameObject);
          //  trigger = false;
        }
    }
}
