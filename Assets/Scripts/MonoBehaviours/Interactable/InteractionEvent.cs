using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionEvent : MonoBehaviour {

    public delegate void InteractionEventHandler(Interactable obj);
    public static event InteractionEventHandler OnInteract;

    public static void InteractionStart(Interactable obj)
    {
        if (OnInteract != null)
            OnInteract(obj);
    }

}

