using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBattle : SceneInt
{
    public BattleController bc;

  /*  // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    */

    override public void Interact()
    {
        //  Debug.Log(trigger);
        sceneName = bc.scName;
        if (bc.health<0||bc.enemy<0)
        {
            SpecificInit();
            ImmediateReaction();
            // trigger = false;
        }

    }
}
