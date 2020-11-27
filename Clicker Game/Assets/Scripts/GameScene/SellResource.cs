using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellResource : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton ()
    {
        GlobalResources.ResourceCount -= 1;
        GlobalCash.CashCount += 1;
    }
}
