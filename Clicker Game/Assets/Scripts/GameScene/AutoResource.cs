using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResource : MonoBehaviour
{
    public bool CreatingResource = false;
    public static int ResourceIncrease = 1;
    public int InternalIncrease;
   
    void Update()
    {
        ResourceIncrease = GlobalCoalmine.coalminePerSec;
        InternalIncrease = ResourceIncrease;
        if (CreatingResource == false)
        {
            CreatingResource = true;
            StartCoroutine(CreateTheResource());
        }
    }

    IEnumerator CreateTheResource ()
    {
        GlobalResources.ResourceCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingResource = false;
    }
}
