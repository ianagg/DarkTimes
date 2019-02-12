using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTextController : MonoBehaviour {

    private static PopUpText popupText;
    private static GameObject canvas;

    // public static void Initialize() {
    public void Awake()
    {
     
        canvas =  GameObject.Find("Canvas");
        popupText = Resources.Load<PopUpText>("Prefabs/PopUpTextParent");
      //  Debug.Log("done!!!");

    }

    public static void CreateText(string text, float location) {

       // Debug.Log(location.position.x+"######");

        PopUpText inst = Instantiate(popupText);
            //new Vector2(location.position.x + Random.Range(-.5f, .5f), location.position.y + Random.Range(-.5f, .5f));

        
        inst.transform.SetParent(canvas.transform, false);
        //inst.transform.position = location.position;
        inst.transform.localPosition = new Vector3(location, 0,0);
        inst.SetDamage("-" + text);

    }


}
