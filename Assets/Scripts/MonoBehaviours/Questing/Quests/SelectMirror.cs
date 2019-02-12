using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMirror : Quest
{

    // Use this for initialization
    void Start()
    {
        QuestName = "SelectMirror";
        Goals.Add(new SelectionGoal(this, "mirror", "no_mirror", "select 2 proper mirrors", false, 0, 2));
       
        Goals.ForEach(g => g.Init());
    }


    public override void GiveReward()
    {
        //   base.GiveReward();
        GameObject go = GameObject.Find("vase_2");
        go.transform.position = new Vector3(-27.73f, -4.31f, -7f);
        //go.GetComponent<BoxCollider>().enabled = true;

        Debug.Log("SelectMirror complete");

    }
}
