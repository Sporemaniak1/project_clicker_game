using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResource7 : MonoBehaviour
{
    public bool CreatingResource7 = false;
    public static int Resource7Increase = -1;
    public int InternalIncrease;
   
    void Update()
    {
        Resource7Increase = GlobalSasiniummine.sasiniumminePerSec;
        InternalIncrease = Resource7Increase;
        if (CreatingResource7 == false)
        {
            CreatingResource7 = true;
            StartCoroutine(CreateTheResource());
        }
    }

    IEnumerator CreateTheResource ()
    {
        GlobalResources.ResourceCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingResource7 = false;
    }
}
