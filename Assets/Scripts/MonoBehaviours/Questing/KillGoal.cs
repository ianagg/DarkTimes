using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillGoal : Goal
{
   private int number = 0;
   private int[] List = new int [4];
   public string EnemyId { get; set; }

    public KillGoal(Quest quest, string enemyId, string description, bool completed, int currentAmout, int requiredAmount, int[] list)
    {
        this.Quest = quest;
        this.EnemyId = enemyId;
        this.Completed = completed;
        this.RequiredAmount = requiredAmount;
        this.CurrentAmount = currentAmout;
        this.Description = description;
        this.List = list;
    }



    public override void Init()
    {
        base.Init();
        InteractionEvent.OnInteract += EnemyHit;
    }

    void EnemyHit(Interactable enemy)
    {

        if (enemy.itemID == this.EnemyId)
          {
        if (enemy.hitvalue == this.List[number])
        {
            this.CurrentAmount++;
            number++;
            Evaluate();
            Debug.Log("Hit:" + enemy.hitvalue);
        }
        else {
            number = 0;
            this.CurrentAmount = 0;
            Debug.Log("Miss:" + enemy.hitvalue);
        }
        }
    }

}
