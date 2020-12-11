using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoResource;
    public GameObject AutoSell;
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
    public void StartAutoSell()
    {
        playSound.Play();
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 2; //mnoznik wartosci surowcow z kopalni
        GlobalShop.turnOffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }
}
