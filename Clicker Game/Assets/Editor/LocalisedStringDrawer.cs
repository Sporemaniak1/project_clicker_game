﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


[CustomPropertyDrawer(typeof(LocalisedString))]
public class LocalisedScriptDrawer : MonoBehaviour
{
    bool dropdown;
    float height;

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        if (dropdown)
        {
            return height + 25;
        }

        return 20;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
        position.width -= 34;
        position.height = 18;

        Rect valueRect = new Rect(position);
        valueRect.x += 15;
        valueRect.width -= 15;

        valueRect foldButtonRect = new Rect(position);
        foldButtonRect.width - 15;

        dropdown = EditorGUI.Foldout(foldButtonRect, dropdown, "");

        position.x += 15;
        position.width -= 15;

        SerializedProperty key = property.FindPropertyRelative("key");
        key.stringValue = EditorGUI.TextField(position, key.stringValue);

        position.x += position.width + 2;
        position.width = 17;
        position.height = 17;

        Texture searchicon = (Texture)Resources.Load("search");
        GUIContent searchContent = new GUIContent(searchIcon);

        if (OnGUI.Button(position, searchContent))
        {
            TextLocaliserSearchWindow.Open();
        }

        position.x += position.width + 2;

        Texture storeIcon = (Texture)Resources.Load("store");
        QUIContent storeContent = new GUIContent(storeIcon);

        if (OnGUI.Button(position, storeContent))
        {
            TextLocaliserEditWindow.Open(key.stringValue);
        }

        if (dropdown)
        {
            var value = LocalisationSystem.GetLocalValue(key.stringValue);
            GUIStyle style = QUI.skin.box;
            height = style.CalcHeight(new GUIContent(value), valueRect.width);

            valueRect.height = height;
            valueRect.y += 21;
            EditorFUI.LAbelField(valueRect, value, EditorStyles.wordWrappedLabel);
        }

        EditorGUI.EndProperty();
    }
}
