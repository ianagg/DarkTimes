using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {

    public GameObject green;
    public GameObject yellow;
    public GameObject red;


    public Transform enemyTr;
    public Transform playerTr;
    public Interactable boss;

    public int hit;

   // public string sceneName;


    public float health;
    private float speed;

    public float enemy;

    private bool stop;

//    public string sceneName;
    public SceneController sceneController;
    private GameObject inv;

    public string scName;

    private void Start()
    {
        sceneController = FindObjectOfType<SceneController>();
        scName = sceneController.previousSceneName;

        inv = GameObject.Find("Inventory");
        inv.gameObject.SetActive(false);

        stop = false;
        speed = 0.3f;
        health = 100f;

        if (scName == "Room5") 
            enemy = 1000f;
            else 
            enemy = 100f;

        green.SetActive(true);
        yellow.SetActive(false);
        red.SetActive(false);

            
        
    }


    void Update () {


        Debug.Log(health + " : " + enemy);

        if ((health > 0 && enemy > 0) || !stop)
        {

          //  if (!stop)
            //{
               // stop = true;
                StartCoroutine(PlayerMove());
            //}
            //else
            //{
              //  stop = false;
                //StartCoroutine(EnemyMove());
           // }
        }
        else
        {
            boss.enabled = false;
            this.transform.position = new Vector3(-10f, -3.29f, -1f);
            sceneController.FadeAndLoadScene(scName);
        }


    }


    private IEnumerator EnemyMove() {

        
        this.transform.position = new Vector3(-10f, -3.29f, -1f);
       // yield return new WaitForSeconds(2);
        System.Random rnd = new System.Random();
        int enemyHit = rnd.Next(0, 100);
        int t = 8;

        if (enemyHit > 40) {
            t = 15;
            health -= 10;
        }
        if (enemyHit > 98) {
            t = 40;
            health -= 40;
        }
        ChangeColor();

        yield return new WaitForSeconds(0.5f);
        PopUpTextController.CreateText(t.ToString(), -300f);
        Debug.Log("you got hit");
        yield return new WaitForSeconds(1f);

        yield return stop=false;
    }


    private IEnumerator BossMove()
    {


        this.transform.position = new Vector3(-10f, -3.29f, -1f);
        // yield return new WaitForSeconds(2);
        //System.Random rnd = new System.Random();
        // int enemyHit = rnd.Next(0, 100);
        //  int t = 8;

        health -= 24;

    
      //  ChangeColor();

        yield return new WaitForSeconds(0.5f);
        PopUpTextController.CreateText("25", -300f);
        Debug.Log("you got hit");
        yield return new WaitForSeconds(1f);

        yield return stop = false;
    }



    private IEnumerator PlayerMove()
    {
        if (!stop)
        {
           
            this.transform.position += new Vector3(speed, 0, 0);
            if (this.transform.position.x > 9.5f)
                this.transform.position = new Vector3(-10f, -3.29f, -1f);


            if (Input.GetKeyDown("space"))
            {
                Debug.Log("you hit "+ hit);

                if (scName != "Room5")
                {
                    PopUpTextController.CreateText(hit.ToString(), 300f);
                    enemy -= hit;
                    stop = true;

                    if (enemy > 0)
                    {
                        StartCoroutine(EnemyMove());
                    }
                }
                else {
                    boss.hitvalue = hit;
                    InteractionEvent.InteractionStart(boss);
                    PopUpTextController.CreateText("???", 300f);
                    stop = true;
                    StartCoroutine(BossMove());

                }
                yield return new WaitForSeconds(2);
            }



        }
        yield return null;
    }




    void ChangeColor() {

        if (health < 70) {

            green.SetActive(false);
            yellow.SetActive(true);
            red.SetActive(false);

            speed = 0.55f;
        }

        if (health < 30)
        {

            green.SetActive(false);
            yellow.SetActive(false);
            red.SetActive(true);

            speed = 0.8f;
        }


    }

    /*
    {
        if (health < 0 || enemy < 0)
        {
            sceneController.FadeAndLoadScene(sceneController.previousSceneName);

        }
    }

    */
}
