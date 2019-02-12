using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TransformationHandle : MonoBehaviour//, IPointerClickHandler 

{
    public GameObject bat;
    public GameObject human;
    public GameObject vampire;

    public GameObject wheel;

    private string state;

    //Detect if a click occurs
    // public void OnPointerClick(PointerEventData pointerEventData)
    void OnMouseDown()
    {
       if (name.Equals("bat"))
        {
            bat.SetActive(true);
            human.SetActive(false);
            vampire.SetActive(false);

        }
        if (name.Equals("human"))
        {
            bat.SetActive(false);
            human.SetActive(true);
            vampire.SetActive(false);

        }
        if (name.Equals("vampire"))
        {
            bat.SetActive(false);
            human.SetActive(false);
            vampire.SetActive(true);

        }

        wheel.SetActive(false);

        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        Debug.Log(name + " Game Object Clicked!");
    }


}
