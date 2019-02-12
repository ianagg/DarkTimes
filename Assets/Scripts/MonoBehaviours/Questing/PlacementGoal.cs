using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementGoal : Goal {
    public string ItemId { get; set; }

    public PlacementGoal(Quest quest, string itemId, string description, bool completed, int currentAmout, int requiredAmount)
    {
        this.Quest = quest;
        this.ItemId = itemId;
        this.Completed = completed;
        this.RequiredAmount = requiredAmount;
        this.CurrentAmount = currentAmout;
        this.Description = description;

    }



    public override void Init()
    {
        base.Init();
        InteractionEvent.OnInteract += ItemPlaced;
    }

    void ItemPlaced(Interactable item)
    {

        if (item.itemID == this.ItemId)
        {
            this.CurrentAmount++;
            Evaluate();
        }
    }
}

