using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionGoal : Goal
{
    public string ItemId { get; set; }
    public string WrongItemId { get; set; }
    public int WrongAmount { get; set; }

    public SelectionGoal(Quest quest, string itemId, string wrongItemId, string description, bool completed, int currentAmout, int requiredAmount)
    {
        this.Quest = quest;
        this.ItemId = itemId;
        this.Completed = completed;
        this.RequiredAmount = requiredAmount;
        this.CurrentAmount = currentAmout;
        this.Description = description;
        this.WrongAmount = 0;
        this.WrongItemId = wrongItemId;
    }



    public override void Init()
    {
        base.Init();
        InteractionEvent.OnInteract += ItemSelected;
    }

    void ItemSelected(Interactable item)
    {

        if (item.itemID == this.ItemId && item.hitvalue==1)
        {
            this.CurrentAmount++;
            SelectionEvaluate();
        }

        if (item.itemID == this.ItemId && item.hitvalue == 0)
        {
            this.CurrentAmount--;
            SelectionEvaluate();
        }

        if (item.itemID == this.WrongItemId && item.hitvalue == 1) {
           this.WrongAmount++;
            SelectionEvaluate();

        }

        if (item.itemID == this.WrongItemId && item.hitvalue == 0)
        {
            this.WrongAmount--;
            SelectionEvaluate();

        }
    }



    public void SelectionEvaluate()
    {

        Debug.Log(CurrentAmount + "/" + RequiredAmount);
        if (CurrentAmount == RequiredAmount && WrongAmount == 0)
        {
            // Debug.Log("complete");
            Complete();
        }

    }


}


