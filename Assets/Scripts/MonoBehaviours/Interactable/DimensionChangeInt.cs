using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DimensionChangeInt : SceneInt {



	// Use this for initialization
	void Start () {
        trigger = true;	
	}

    
    override public void Interact()
    {
        //  Debug.Log(trigger);

        if (trigger)
        {

            string n = SceneManager.GetActiveScene().name;
            if (n.StartsWith("Room"))
            {
                if (!n.EndsWith("3D")&&(SceneUtility.GetBuildIndexByScenePath(n + "_3D") >= 0))
                    sceneName = n + "_3D";
                else
                {
                    sceneName = n.Split('_')[0];
                  //  this.gameObject.SetActive(true);
                    //Debug.Log(this.isActiveAndEnabled);
                }
            }
            SpecificInit();
            ImmediateReaction();
            // trigger = false;
        }
        

    }
    
    // Update is called once per frame
    void Update () {

       
    }

    

}
