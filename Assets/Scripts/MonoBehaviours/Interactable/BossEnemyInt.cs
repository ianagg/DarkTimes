using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyInt : Interactable {
    private SceneController sceneController;
    public string sceneName;

   // public int hits = 4;


    // Use this for initialization
    void Start () {
        sceneController = FindObjectOfType<SceneController>();

    }

    // Update is called once per frame
    void Update () {
		

	}

    override public void Interact()
    {
        if (trigger)
        {

            sceneController.previousSceneName = sceneName;
            sceneController.FadeAndLoadScene("BattleMode");
            // InteractionEvent.InteractionStart(this);

        }
    }

}
