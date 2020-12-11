using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool SellingResource = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;
   
    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingResource == false)
        {
            SellingResource = true;
            StartCoroutine(SellTheResource());
        }
    }

    IEnumerator SellTheResource ()
    {
        if(GlobalResources.ResourceCount == 0)
        {
            //nie możemy nic zrobić
        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalResources.ResourceCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingResource = false;
        }
        
    }
}
