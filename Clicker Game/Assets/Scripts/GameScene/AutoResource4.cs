using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResource4 : MonoBehaviour
{
    public bool CreatingResource4 = false;
    public static int Resource4Increase = 30;
    public int InternalIncrease;
   
    void Update()
    {
        Resource4Increase = GlobalEmeraldmine.emeraldminePerSec;
        InternalIncrease = Resource4Increase;
        if (CreatingResource4 == false)
        {
            CreatingResource4 = true;
            StartCoroutine(CreateTheResource());
        }
    }

    IEnumerator CreateTheResource ()
    {
        GlobalResources.ResourceCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingResource4 = false;
    }
}
