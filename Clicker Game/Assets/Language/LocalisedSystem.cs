using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public struct LocalisedSystem
{
    public string key;

    public LocalisedSystem(string key)
    {
        this.key = key;
    }

    public string value
    {
        get
        {
            return LocalisationSystem.GetLocalisedValue(key);
        }
    }

    public static implicit operator LocalisedSystem(string key)
    {
        return new LocalisedSystem(key);
    }
}
