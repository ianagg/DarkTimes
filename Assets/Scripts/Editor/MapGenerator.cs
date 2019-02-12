using UnityEditor;
using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class MapGenerator : MonoBehaviour
{
    private static ListObjData data;

    [MenuItem("Map/Generate")]
   public static void GenerateMap(MenuCommand menuCommand)
    {
        Debug.Log("generating...");
        // Create a custom game object

        LoadMap();

        for (int i = 0; i < data.list.Length; i++)
        {

            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
           // GameObject go = new GameObject(data.list[i].name);
            go.name = data.list[i].name;
            go.transform.localScale = new Vector3(2f, 2f, 2f);
            // Ensure it gets reparented if this was a context click (otherwise does nothing)
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            // Register the creation in the undo system
            Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
            Selection.activeObject = go;
            float extra = go.GetComponent<Renderer>().bounds.size.x; //+ go.GetComponent<Renderer>().bounds.size.y;

          //  Debug.Log(extra+go.name);

            float test = data.list[i].z;
            if (test != 0)
                test *= 10;

            go.transform.position = new Vector3(data.list[i].x*extra, 0f, test);


        }
    }


    public static void LoadMap() {
        if (File.Exists(Application.dataPath + "/2Dobjects.map")){
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.dataPath + "/2Dobjects.map", FileMode.Open);

            data = (ListObjData) bf.Deserialize(stream);

            stream.Close();


        }



    }



}



