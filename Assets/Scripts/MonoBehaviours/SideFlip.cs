using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideFlip : MonoBehaviour {

    private SpriteRenderer mySpriteRenderer;
    private Animator anim;

    private void Start()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // This function is called by Unity every frame
    private void Update()
    {
        // if the variable isn't empty (we have a reference to our SpriteRenderer)
        if (mySpriteRenderer != null)
        {
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && !(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
            {
                // flip the sprite
                anim.SetBool("move", true);
                mySpriteRenderer.flipX = false;

            }

            // if the A key was pressed this frame
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && !(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
            {
                // flip the sprite
                mySpriteRenderer.flipX = true;
                anim.SetBool("move", true);
            }

           
          
           


            if (!(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
                anim.SetBool("move", false);
            
        }
    }
}
