using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThreeDHandle : MonoBehaviour {

    public GameObject button;
    public GameObject bat;

    // Use this for initialization
    void Start () {
       // bat = GameObject.Find("PlayerB");
    }
	
	// Update is called once per frame
	void Update () {


        if (!SceneManager.GetActiveScene().name.EndsWith("3D") && bat == null)
        {
            bat = GameObject.Find("PlayerB");

        }
            if (bat!=null&&bat.activeSelf)
            {
                button.SetActive(true);
            }
            else
            {
                button.SetActive(false);
            }
        //}
	}
}
