using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInt : Interactable {

    private GameObject go;
    private OpenDoor q;
    private bool end = false;
    public GameObject vase;
    public Inventory inventory;
    // Use this for initialization
    void Start()
    {
       inventory = FindObjectOfType<Inventory>();
     //  int i = inventory.itemImg.Length;
        int count = 0;
        for (int j = 0; j < 2; j++) {
            if (inventory.itemImg[j].sprite.name.StartsWith("vase")) {
                count++;
                Debug.Log("******" + count + "*******");
            }

        }

        if (count == 2)
            end = true;
        // go = GameObject.Find("Quest");
        // end = q.Done;
    }
	
	// Update is called once per frame
	void Update () {
       // end = go.GetComponent<OpenDoor>().Done;
    }



    override public void Interact()
    {
        if (trigger)
        {
            Debug.Log(end);
            if (end)
            {
                vase.transform.position = new Vector3(14.52f, 0.6f, 0f);
                this.itemID = "vase";
                //InteractionEvent.InteractionStart(this);
              //  end = false;
            }

            // inventory.AddItem(i);
            InteractionEvent.InteractionStart(this);
           // this.gameObject.SetActive(false);

            // Destroy(this.gameObject);
            //  trigger = false;
        }
    }
}
