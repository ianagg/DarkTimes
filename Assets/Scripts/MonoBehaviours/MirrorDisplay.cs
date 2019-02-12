using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorDisplay : MonoBehaviour {

    public GameObject h;
    public GameObject v;
    public GameObject mirror_h;
    public GameObject mirror_v;


    //public string state;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log("h:" + h.activeSelf);
        Debug.Log("v:" + v.activeSelf);


        if (h.activeSelf) {
            mirror_h.SetActive(true);
            mirror_v.SetActive(false);

        }
        if (v.activeSelf)
        {
            mirror_v.SetActive(true);
            mirror_h.SetActive(false);

        }
        if (!v.activeSelf && !h.activeSelf)
        {
            mirror_v.SetActive(false);
            mirror_h.SetActive(false);


        }

    }
}
