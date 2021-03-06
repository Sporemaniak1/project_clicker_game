﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalisationSystem : MonoBehaviour
{
    public enum Language // dostepne jezyki
    {
        English,
        Polski
    }

    public Dropdown LangList;
    public Text SelectedLanguage;

    public void DropdownIndexChanges(int index)
    {
        // SelectedLanguage.text = names[index];
    }

    void Start()
    {
        SetLanguage();
    }

    void SetLanguage()
    {
        string[] enumNames = Enum.GetNames(typeof(Language));
        List<string> names = new List<string>(enumNames);
        LangList.AddOptions(names);
    }

    public static Language language = Language.Polski; // domyslny jezyk

    private static Dictionary<string, string> localisedEN;
    private static Dictionary<string, string> localisedPL;

    public static bool isInit;

    public static CSVLoader csvLoader;

    public static void Init()
    {
        csvLoader = new CSVLoader();
        csvLoader.LoadCSV();

        UpdateDictionaries();

        isInit = true;
    }

    public static void UpdateDictionaries()
    {
        localisedEN = csvLoader.GetDictionaryValues("en");
        localisedPL = csvLoader.GetDictionaryValues("pl");
    }

    public static Dictionary<string, string> GetDictionaryForEditor()
    {
        if (!isInit) { Init(); }
        return localisedEN;
    }

    public static string GetLocalisedValue(string key)
    {
        if(!isInit) { Init(); }

        string value = key;

        switch(language)
        {
            case Language.English:
                localisedEN.TryGetValue(key, out value);
                break;

            case Language.Polski:
                localisedPL.TryGetValue(key, out value);
                break;
        }

        return value;
    }

    public static void Add(string key, string value)
    {
        if (value.Contains ("\""))
        {
            value.Replace('"', '\"');
        }

        if (csvLoader == null)
        {
            csvLoader = new CSVLoader();
        }

        csvLoader.LoadCSV();
        csvLoader.Add(key, value);
        csvLoader.LoadCSV();

        UpdateDictionaries();
    }

    public static void Replace(string key, string value)
    {
        if (value.Contains("\""))
        {
            value.Replace('"', '\"');
        }

        if (csvLoader == null)
        {
            csvLoader = new CSVLoader();
        }

        csvLoader.LoadCSV();
        csvLoader.Edit(key, value);
        csvLoader.LoadCSV();

        UpdateDictionaries();
    }

    public static void Remove(string key)
    {
        if (csvLoader == null)
        {
            csvLoader = new CSVLoader();
        }

        csvLoader.LoadCSV();
        csvLoader.Remove(key);
        csvLoader.LoadCSV();

        UpdateDictionaries();
    }
}
