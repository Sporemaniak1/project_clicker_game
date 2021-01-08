using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageSelect : MonoBehaviour
{
    List<string> names = new List<string>() { "Select Language", "English", "Polski" };

    public Dropdown LangList;
    public Text SelectedLanguage;

    public void DropdownIndexChanges(int index)
    {
        SelectedLanguage.text = names[index];
    }

    void Start()
    {
        SetLanguage();
    }

    void SetLanguage()
    {
        LangList.AddOptions(names);
    }

    
}
