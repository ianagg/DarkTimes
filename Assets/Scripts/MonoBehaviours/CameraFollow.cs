using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CameraFollow : MonoBehaviour {
    private GameObject go;
    public Vector3 offset;         
    // Use this for initialization
    void Start () {

       
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (!SceneManager.GetActiveScene().name.EndsWith("3D") && SceneManager.GetActiveScene().name.StartsWith("R"))
        {
            go = GameObject.FindGameObjectWithTag("Player");
            transform.position = go.transform.position + offset;
        }
      //  transform.position = go.transform.position;
    
    }

}
