using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell1 : MonoBehaviour
{
    public bool Selling1Resource = false;
    public static int Cash1Increase = 30;
    public int InternalIncrease;
   
    void Update()
    {
        Cash1Increase = GlobalMarket.marketPerSec;
        InternalIncrease = Cash1Increase;
        if (Selling1Resource == false)
        {
            Selling1Resource = true;
            StartCoroutine(SellTheResource());
        }
    }

    IEnumerator SellTheResource ()
    {
        if (GlobalResources.ResourceCount <= (-1 + InternalIncrease)) 
        {
            Selling1Resource = false; 

        }
        
            
        
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalResources.ResourceCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            Selling1Resource = false;
        }
        
    }
}
