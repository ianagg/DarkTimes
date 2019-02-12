using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour {

    public string dim;
    private GameObject cam;
    private RoomGeneration room;

    // Use this for initialization
    void Start () {

        if (dim.Equals("3D"))

            cam = GameObject.Find("Player3D");
        else
            cam = GameObject.Find("Main Camera");
        //room = GameObject.Find("Generation").GetComponent<RoomGeneration>();
    }

    // Update is called once per frame
    void Update() {

        if (this.transform.position.x < cam.transform.position.x - 60) {
            Destroy(gameObject);
      //      room.llaststop -= 20.48261f;
        }

        //if( this.transform.position.x > cam.transform.position.x + 70) {
          //  Destroy(gameObject);
            //room.rlaststop += 20.48261f;
//        }

	}
}
