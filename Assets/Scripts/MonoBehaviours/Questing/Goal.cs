using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal {

    public Quest Quest { get; set; }
    public bool Completed { get; set; }
    public int CurrentAmount { get; set; }
    public int RequiredAmount { get; set; }
    public string Description { get; set; }
   

    public virtual void Init() {


    }



    public void Evaluate() {

        Debug.Log(CurrentAmount+"/" +RequiredAmount);
        if (CurrentAmount == RequiredAmount) {
           // Debug.Log("complete");
            Complete();
        }

    }

    public void Complete() {
        Completed = true;
        Quest.CheckGoals();
      
    }


}
