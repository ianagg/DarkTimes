using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderFollow : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D)) {
           // print("key was pressed");
            transform.position += new Vector3(0.02f,0,0);
          }
    }
}
