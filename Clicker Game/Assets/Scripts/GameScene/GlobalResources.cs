using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalResources : MonoBehaviour
{
    public static int ResourceCount;
    public GameObject ResourceDisplay;
    public int InternalResources;

    void Update()
    {
        InternalResources = ResourceCount;
        ResourceDisplay.GetComponent<Text>().text = "Resources: " + InternalResources;
    }
}
