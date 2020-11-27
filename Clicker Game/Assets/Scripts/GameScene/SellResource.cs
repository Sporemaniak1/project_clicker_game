using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellResource : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;
    public void ClickTheButton ()
    {
        if (GlobalResources.ResourceCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough resources to sell. ";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalResources.ResourceCount -= 1;
            GlobalCash.CashCount += 1;
        }
       
    }
}
