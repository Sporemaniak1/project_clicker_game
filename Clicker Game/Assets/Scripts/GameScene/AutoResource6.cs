using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoResource6 : MonoBehaviour
{
    public bool CreatingResource6 = false;
    public static int Resource6Increase = 80;
    public int InternalIncrease;
   
    void Update()
    {
        Resource6Increase = GlobalNickelmine.nickelminePerSec;
        InternalIncrease = Resource6Increase;
        if (CreatingResource6 == false)
        {
            CreatingResource6 = true;
            StartCoroutine(CreateTheResource());
        }
    }

    IEnumerator CreateTheResource ()
    {
        GlobalResources.ResourceCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingResource6 = false;
    }
}
