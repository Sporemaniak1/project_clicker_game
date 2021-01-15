using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResource2 : MonoBehaviour
{
    public bool CreatingResource2 = false;
    public static int Resource2Increase = 5;
    public int InternalIncrease;
   
    void Update()
    {
        Resource2Increase = GlobalGoldmine.goldminePerSec;
        InternalIncrease = Resource2Increase;
        if (CreatingResource2 == false)
        {
            CreatingResource2 = true;
            StartCoroutine(CreateTheResource());
        }
    }

    IEnumerator CreateTheResource ()
    {
        GlobalResources.ResourceCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingResource2 = false;
    }
}
