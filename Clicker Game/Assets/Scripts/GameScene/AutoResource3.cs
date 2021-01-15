using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResource3 : MonoBehaviour
{
    public bool CreatingResource3 = false;
    public static int Resource3Increase = 20;
    public int InternalIncrease;
   
    void Update()
    {
        Resource3Increase = GlobalIronmine.ironminePerSec;
        InternalIncrease = Resource3Increase;
        if (CreatingResource3 == false)
        {
            CreatingResource3 = true;
            StartCoroutine(CreateTheResource());
        }
    }

    IEnumerator CreateTheResource ()
    {
        GlobalResources.ResourceCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingResource3 = false;
    }
}
