using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResource5 : MonoBehaviour
{
    public bool CreatingResource5 = false;
    public static int Resource5Increase = 50;
    public int InternalIncrease;
   
    void Update()
    {
        Resource5Increase = GlobalDiamondmine.diamondminePerSec;
        InternalIncrease = Resource5Increase;
        if (CreatingResource5 == false)
        {
            CreatingResource5 = true;
            StartCoroutine(CreateTheResource());
        }
    }

    IEnumerator CreateTheResource ()
    {
        GlobalResources.ResourceCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingResource5 = false;
    }
}
