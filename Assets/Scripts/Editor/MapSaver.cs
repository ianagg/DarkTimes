using UnityEditor;
using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class MapSaver : MonoBehaviour
{

   

    [MenuItem("Map/Save")]
    public static void GenerateMap(MenuCommand menuCommand)
    {

        SaveMap();
    }


    public static void SaveMap()
    {
        Debug.Log("saving...");

       // MapData data = new MapData();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.dataPath + "/2Dobjects.map", FileMode.Create);

        ListObjData data = new ListObjData();

        bf.Serialize(stream, data);
        stream.Close();
    }

}

[Serializable]
public class ListObjData {

    public ObjData[] list;

    public  ListObjData () { 

        GameObject[] allObj = GameObject.FindGameObjectsWithTag("Save");

        list = new ObjData[allObj.Length];
        for (int i = 0; i < allObj.Length; i++)
        {
            Debug.Log(allObj[i].name);
            list[i] = new ObjData(allObj[i]);
        }
    }


}

[Serializable]
public class ObjData {

    public string name;
    public float x;
    public float z;
    //1 - back; 0 - player; -1 - front;


    public ObjData(GameObject go) {

           name = go.name;
           x = go.transform.position.x;
           z  = go.transform.position.z;

        } 


}



