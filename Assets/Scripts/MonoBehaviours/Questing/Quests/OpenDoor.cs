using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : Quest {

	// Use this for initialization
	void Start () {
        QuestName = "OpenDoor";
        Goals.Add(new CollectionGoal(this, "collection", "collect 2 magic runes", false, 0, 2));
        Goals.Add(new PlacementGoal(this, "vase", "place the vase", false, 0, 1));

        Goals.ForEach(g => g.Init());
    }


    public override void GiveReward()
    {
        //   base.GiveReward();
        GameObject go = GameObject.Find("OpenDoor");
        go.GetComponent<BoxCollider>().enabled = true;

        GameObject inv = GameObject.Find("Inventory");
        inv.gameObject.SetActive(false);


        Debug.Log("OpenDoor complete");

    }

}
