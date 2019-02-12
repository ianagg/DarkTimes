using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableInv : MonoBehaviour {

	// Use this for initialization
	void Start () {
       

    }

    // Update is called once per frame
    void Update () {
        GameObject inv = GameObject.Find("Inventory");
        if(inv!=null)
        inv.gameObject.SetActive(false);
    }
}
