using UnityEngine;

public class Interactable : MonoBehaviour {

    //  public float radius = 2;

    public string itemID;
    protected bool trigger;
    public int hitvalue;

   // public delegate void InteractionComplete();
   // public event InteractionComplete OnInteract;


    private void Start()
    {
        trigger = false;


    }

    void AudioResponce() {

    }

    void TextResponce()
    {
     //  Debug.Log(this.name + " " + trigger);
    }

    public virtual void Interact() {

        Debug.Log(this.name+" interact");

    }

    void OnMouseDown()
    {

        AudioResponce();
        TextResponce();
        Interact();
//        Destroy(this.gameObject);

    }


    private void OnTriggerEnter(Collider other)
    {
      //  Debug.Log("uqwetqtu");

        if (other.gameObject.name.StartsWith("Player"))
        {
            trigger = true;
            if (itemID == "doorTo3") {
                Interact();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.StartsWith("Player"))
        {
            trigger = false;
        }
    }

}
