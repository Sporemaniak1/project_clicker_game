using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell3 : MonoBehaviour
{
    public bool Selling3Resource = false;
    public static int Cash3Increase = 150;
    public int InternalIncrease;
   
    void Update()
    {
        Cash3Increase = GlobalHypermarket.hypermarketPerSec;
        InternalIncrease = Cash3Increase;
        if (Selling3Resource == false)
        {
            Selling3Resource = true;
            StartCoroutine(SellTheResource());
        }
    }

    IEnumerator SellTheResource ()
    {
        if (GlobalResources.ResourceCount <= (-1 + InternalIncrease)) 
        {
            Selling3Resource = false; 

        }
        
            
        
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalResources.ResourceCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            Selling3Resource = false;
        }
        
    }
}
