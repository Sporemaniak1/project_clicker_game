using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoResource;

    public void StartAutoResource()
    {
        AutoResource.SetActive(true);
    }
}
