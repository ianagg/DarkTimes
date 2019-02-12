using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInt : Interactable {

    public string sceneName;
    public Transform player;
    private SceneController sceneController;
    private float speed = 2.3f;

    // Use this for initialization
    void Start () {
        sceneController = FindObjectOfType<SceneController>();
    }

    // Update is called once per frame
    void Update () {

        float dis = Vector2.Distance(transform.position, player.position);

        if ( dis > 3f)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {

            Interact();
        }
    }

    override public void Interact()
    {
      //   Debug.Log(trigger);

       // if (trigger)
       // {

            sceneController.previousSceneName = sceneName;
            sceneController.FadeAndLoadScene("BattleMode");
           
       // }

    }
}
