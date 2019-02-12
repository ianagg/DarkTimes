using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Quest : MonoBehaviour {

    private List<Goal> goals = new List<Goal>();
    private bool done = false;

    public List<Goal> Goals
    {
        get
        {
            return goals;
        }

        set
        {
            goals = value;
        }
    }

    public string QuestName { get; set; }
   // public bool Reward { get; set; }
    public bool Completed { get; set; }

    public bool Done
    {
        get
        {
            return done;
        }

        set
        {
            done = value;
        }
    }

    public void CheckGoals()
    {
       Debug.Log("checking the goals...");
       Completed = Goals.All(g=> g.Completed);
       Debug.Log("goals: "+ Completed);

        if (Completed) GiveReward();
    }


   public virtual void GiveReward()
    {


    }






}
