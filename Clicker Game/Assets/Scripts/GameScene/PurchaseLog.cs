using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoResource;
    public AudioSource playSound;

    public void StartAutoResource()
    {
        playSound.Play();
        AutoResource.SetActive(true);
        GlobalCash.CashCount -= GlobalCoalmine.coalmineValue;
        GlobalCoalmine.coalmineValue *= 2; //mnoznik wartosci surowcow z kopalni
        GlobalCoalmine.turnOffButton = true;
        GlobalCoalmine.coalminePerSec += 1;
        GlobalCoalmine.numberOfCoalmines += 1;
    }
}
