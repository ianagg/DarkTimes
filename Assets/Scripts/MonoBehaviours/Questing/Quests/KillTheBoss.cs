using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTheBoss : Quest
{
   

    // Use this for initialization
    void Start()
    {
        QuestName = "KillTheBoss";
        int[] val = { 15, 15, 15, 15 };
        Goals.Add(new KillGoal(this, "boss", "hit y y y y", false, 0, 4, val));

        Goals.ForEach(g => g.Init());
    }

    void Update()
    {
        if (Done) {
            GameObject g = GameObject.Find("Boss");
            if (g!=null)
                g.SetActive(false);

            GameObject gate = GameObject.Find("NextScene2");
            gate.transform.position = new Vector3(5.94f, -1.32f, -7f);

            //Done = false;
        }

    }


    public override void GiveReward()
    {
        //   base.GiveReward();
        //  GameObject go = GameObject.Find("KillTheBoss");
        // go.GetComponent<BoxCollider>().enabled = true;

        SceneController sceneController = FindObjectOfType<SceneController>();
        sceneController.FadeAndLoadScene("Room5");
        Done = true;



        Debug.Log("KillTheBoss complete");

    }

}
