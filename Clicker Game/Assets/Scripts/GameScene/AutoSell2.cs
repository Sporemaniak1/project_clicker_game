using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell2 : MonoBehaviour
{
    public bool Selling2Resource = false;
    public static int Cash2Increase = 70;
    public int InternalIncrease;
   
    void Update()
    {
        Cash2Increase = GlobalSupermarket.supermarketPerSec;
        InternalIncrease = Cash2Increase;
        if (Selling2Resource == false)
        {
            Selling2Resource = true;
            StartCoroutine(SellTheResource());
        }
    }

    IEnumerator SellTheResource ()
    {
        if (GlobalResources.ResourceCount <= (-1 + InternalIncrease)) 
        {
            Selling2Resource = false; 

        }
        
            
        
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalResources.ResourceCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            Selling2Resource = false;
        }
        
    }
}
