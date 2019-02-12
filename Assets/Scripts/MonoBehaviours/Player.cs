using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Player : MonoBehaviour //, IPointerClickHandler
{

   
    public GameObject wheel;
    //3.2f
    private float speed = 4.3f;
    private float sens = 2f;

    private float moveH;
    private float moveV;

    private float rotX;
    private float rotY;

    private Camera cam;

    public string dim;

    private CharacterController cc;

    //public SpriteRenderer[] mySpriteRenderer;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
        if (dim.Equals("3D"))
        {
            cam = GameObject.Find("Cam").GetComponent<Camera>();
                
                //Camera.main;
                //this.transform.Find("Cam").gameObject;
        }
    }


    // Update is called once per frame
    void Update()
    {


        //movement

        moveH = Input.GetAxis("Horizontal") * speed;
        Vector3 movement = new Vector3(0,0,0);

        if (dim.Equals("3D"))
        {

            moveV = Input.GetAxis("Vertical") * speed;

            rotX = Input.GetAxis("Mouse X") * sens;
            rotY -= Input.GetAxis("Mouse Y") * sens;
            rotY = Mathf.Clamp(rotY, -60f, 60f);

            movement = new Vector3(moveH, 0f, moveV);
     
            cam.transform.localRotation = Quaternion.Euler(rotY, 0, 0);
            transform.Rotate(0, rotX, 0);

  
        }
        else
        {
            movement = new Vector3(moveH, 0f, 0f);
        }
            movement = transform.rotation * movement;

            cc.Move(movement * Time.deltaTime);
     
    }


    void OnMouseDown()
    {
        wheel.SetActive(!wheel.activeSelf);
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
       // Debug.Log(name + " Game Object Clicked!");
    }


   /* public void OnPointerClick(PointerEventData pointerEventData)
    {
        wheel.SetActive(!wheel.activeSelf);
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        Debug.Log(name + " Game Object Clicked!");
    }
    */
}
