﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

 

    public void OnClickStart()
    {
        SceneManager.LoadScene("UIScene");

    }

    public void OnClickExit()
    {

        Application.Quit();


    }

  

}
