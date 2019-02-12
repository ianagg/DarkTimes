using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {


    public string bat = "null";
    public string hum = "null";
    public string vamp = "null";



    public event Action BeforeSceneUnload;
    public event Action AfterSceneLoad;
    public CanvasGroup faderCanvasGroup;
    public float fadeDuration = 1f;
    public string startingSceneName = "Room1";
    //public string initialStartingPositionName = "DoorToMarket";
    //public SaveData playerSaveData;

    public GameObject inv;

    public string previousSceneName = "Room1";

    private bool isFading;

    public void Check(string sceneName)
    {
        if (!sceneName.EndsWith("3D") && !previousSceneName.EndsWith("3D"))
        {
            Debug.Log("here");
            if (bat == "null" && hum == "null" && vamp == "null")
            {
                GameObject go = GameObject.Find("Player2D");

                if (bat == "null" && go.transform.GetChild(0).gameObject.activeSelf)
                    bat = go.transform.GetChild(0).gameObject.name;

                if (hum == "null" && go.transform.GetChild(1).gameObject.activeSelf)
                    hum = go.transform.GetChild(1).gameObject.name;

                if (vamp == "null" && go.transform.GetChild(2).gameObject.activeSelf)
                    vamp = go.transform.GetChild(2).gameObject.name;


                // Debug.Log(""bat.ToString() + hum.ToString() + vamp.ToString());
            }

        }
        else {
            Debug.Log("not here");
            bat = "PlayerB";
        }


       

    }


    public void Set(string sceneName)
    {
        //&&!previousSceneName.EndsWith("3D")
        if (!sceneName.EndsWith("3D"))
        {
            GameObject go = GameObject.Find("Player2D");
            // Debug.Log(go.transform.childCount + "???");
            int i = -1;

            if (bat != "null")
                i = 0;
            if (hum != "null")
                i = 1;
            if (vamp != "null")
                i = 2;
            if (bat == "null" & hum == "null" & vamp == "null")
                i = 1;

            go.transform.GetChild(0).gameObject.SetActive(false);
            go.transform.GetChild(1).gameObject.SetActive(false);
            go.transform.GetChild(2).gameObject.SetActive(false);

            if (i > -1)
                go.transform.GetChild(i).gameObject.SetActive(true);


            bat = "null";
            hum = "null";
            vamp = "null";
        }
    }



    private IEnumerator Start()
    {
        faderCanvasGroup.alpha = 1f;
      //  playerSaveData.Save(PlayerMovement.startingPositionKey, initialStartingPositionName);
        yield return StartCoroutine(LoadSceneAndSetActive(startingSceneName));
        StartCoroutine(Fade(0f));
    }
    public void FadeAndLoadScene(string name)
    {
        if (!isFading)
        {
            StartCoroutine(FadeAndSwitchScenes(name));
        }
    }
    private IEnumerator FadeAndSwitchScenes(string sceneName)
    {
        Check(sceneName);
        yield return StartCoroutine(Fade(1f));
        if (BeforeSceneUnload != null)
            BeforeSceneUnload();
        yield return SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        yield return StartCoroutine(LoadSceneAndSetActive(sceneName));
        if (AfterSceneLoad != null)
            AfterSceneLoad();

        if (sceneName.StartsWith("Room"))
             Set(sceneName);
        yield return StartCoroutine(Fade(0f));
       

    }
    private IEnumerator LoadSceneAndSetActive(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
      //  previousSceneName = sceneName;
        //  Debug.Log(SceneManager.sceneCount);
        if (sceneName!="BattleMode")
            inv.gameObject.SetActive(true);

        Scene newlyLoadedScene = SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
        SceneManager.SetActiveScene(newlyLoadedScene);


    }
    private IEnumerator Fade(float finalAlpha)
    {
        isFading = true;
        faderCanvasGroup.blocksRaycasts = true;
        float fadeSpeed = Mathf.Abs(faderCanvasGroup.alpha - finalAlpha) / fadeDuration;
        while (!Mathf.Approximately(faderCanvasGroup.alpha, finalAlpha))
        {
            faderCanvasGroup.alpha = Mathf.MoveTowards(faderCanvasGroup.alpha, finalAlpha,
                fadeSpeed * Time.deltaTime);
            yield return null;
        }
        

        isFading = false;
        faderCanvasGroup.blocksRaycasts = false;
    }
}