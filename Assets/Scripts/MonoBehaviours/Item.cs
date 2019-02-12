using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject {

    public Sprite sprite;

    public void Init(Sprite s)
    {
        this.sprite = s;
    }

    public static Item CreateInstance(Sprite s)
    {
        var data = ScriptableObject.CreateInstance<Item>();
        data.Init(s);
        return data;
    }

}
