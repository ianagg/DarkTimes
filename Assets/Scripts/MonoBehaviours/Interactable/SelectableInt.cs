using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableInt : Interactable {
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    override public void Interact()
    {
      

        if (animator.GetBool("active"))
        {
            animator.SetBool("active", false);
            hitvalue = 0;
        }
        else
        {
            animator.SetBool("active", true);
            hitvalue = 1;
        }

        InteractionEvent.InteractionStart(this);


    }
}
