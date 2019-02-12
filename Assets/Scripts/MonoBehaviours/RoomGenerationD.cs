using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGenerationD : MonoBehaviour
{

    public EnableObject[] background;
    public Transform obj;
    public GameObject cam;
    public float walllaststop = 22.93f;
    public float celllaststop = 23.83f;
    public float floorlaststop = 28.20f;
    public float cournerstop = 50.74f;
    //20.48261
    // Use this for initialization
    void Start()
    {

        cam = GameObject.Find("Player3D");
    }

    // Update is called once per frame
    void Update()
    {

//        Debug.Log((cam.transform.position.z)+"\\"+walllaststop);
        if (cam.transform.position.z > walllaststop-100)
        {
            GenerateRightPath();
        }

    }


    public void GenerateRightPath()
    {
        Instantiate(background[0], new Vector3(-6.36f, 2.62f, walllaststop), Quaternion.identity);
        //Instantiate(background[0], new Vector3(2.46f, 2.62f, walllaststop), Quaternion.identity);
        Instantiate(background[1], new Vector3(2.34f, 6.53f, celllaststop), Quaternion.Euler(new Vector3(0, 0, 180)));
        Instantiate(background[2], new Vector3(1.21f, 0, floorlaststop), Quaternion.Euler(new Vector3(0, 90, 0)));
        Instantiate(obj, new Vector3(0f, 0f, cournerstop), Quaternion.identity);
        walllaststop += 22.93f;
        celllaststop += 23.83f;
        floorlaststop += 28.20f;
        cournerstop += 50.74f;

    }


}