using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGeneration : MonoBehaviour {

    public EnableObject background;
    public Camera cam;
    public float rlaststop = 3f;
    public float llaststop = 3f;


    //20.48261
    // Use this for initialization
    void Start () {

        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        if (cam.transform.localPosition.x > (rlaststop - 50))
        {
            GenerateRightPath();
        }

    }


    public void GenerateRightPath()
    {
        Instantiate(background, new Vector3(rlaststop, 2f, 10), Quaternion.identity);
        rlaststop += 20.48261f;
  
    }


}
