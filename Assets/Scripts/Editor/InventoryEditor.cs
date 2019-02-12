using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(Inventory))]
public class InventoryEditor : Editor {

   private SerializedProperty itemImgProp;
    private SerializedProperty itemProp;

    private bool[] showItemSlots = new bool[Inventory.numItemSlots];

    private const string inventoryPropImgName = "itemImg";
    private const string inventoryPropItemName = "items";


    private void OnEnable()
    {
        itemImgProp = serializedObject.FindProperty(inventoryPropImgName);
        itemProp = serializedObject.FindProperty(inventoryPropItemName);
    }


    public override void OnInspectorGUI()
    {
        serializedObject.Update();

        for (int i = 0; i< Inventory.numItemSlots; i++) {
            ItemSlotGUI(i);
        }


        serializedObject.ApplyModifiedProperties();
        //base.OnInspectorGUI();
    }



    private void ItemSlotGUI(int i) {
        EditorGUILayout.BeginVertical(GUI.skin.box);
        EditorGUI.indentLevel++;

        showItemSlots[i] = EditorGUILayout.Foldout(showItemSlots[i], "item slot " + i);

        if (showItemSlots[i]) {
            EditorGUILayout.PropertyField(itemImgProp.GetArrayElementAtIndex(i));
            EditorGUILayout.PropertyField(itemProp.GetArrayElementAtIndex(i));
        }

        EditorGUI.indentLevel--;
        EditorGUILayout.EndVertical();
    }
    

    
    
}
