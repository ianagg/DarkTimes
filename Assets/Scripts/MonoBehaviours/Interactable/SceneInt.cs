using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInt : Interactable
{

    public string sceneName;
   // public string prevSceneName;
    private SceneController sceneController;
    
  

    protected void SpecificInit()
    {   
        sceneController = FindObjectOfType<SceneController>();
    }


    protected void ImmediateReaction()
    {
        //playerSaveData.Save(PlayerMovement.startingPositionKey, startingPointInLoadedScene);
    //    sceneController.previousSceneName = prevSceneName;
        sceneController.FadeAndLoadScene(sceneName);
    }

    override public void Interact()
    {
      //  Debug.Log(trigger);

        if (trigger)
        {
            SpecificInit();
            ImmediateReaction();
           // trigger = false;
        }

    }

}
