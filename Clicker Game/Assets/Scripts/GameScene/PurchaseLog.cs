using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoResource;
    public GameObject AutoSell;
    public AudioSource playSound;
    public GameObject AutoResource2;
    public GameObject AutoResource3;
    public GameObject AutoResource4;
    public GameObject AutoResource5;

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
    public void StartAutoResource2()
    {
        playSound.Play();
        AutoResource2.SetActive(true);
        GlobalCash.CashCount -= GlobalGoldmine.goldmineValue;
        GlobalGoldmine.goldmineValue *= 2;
        GlobalGoldmine.turnOffButton = true;
        GlobalGoldmine.goldminePerSec += 5;
        GlobalGoldmine.numberOfGoldmines += 1;
    }
    public void StartAutoResource3()
    {
        playSound.Play();
        AutoResource3.SetActive(true);
        GlobalCash.CashCount -= GlobalIronmine.ironmineValue;
        GlobalIronmine.ironmineValue *= 2;
        GlobalIronmine.turnOffButton = true;
        GlobalIronmine.ironminePerSec += 20;
        GlobalIronmine.numberOfIronmines += 1;
    }
    public void StartAutoResource4()
    {
        playSound.Play();
        AutoResource4.SetActive(true);
        GlobalCash.CashCount -= GlobalEmeraldmine.emeraldmineValue;
        GlobalEmeraldmine.emeraldmineValue *= 2;
        GlobalEmeraldmine.turnOffButton = true;
        GlobalEmeraldmine.emeraldminePerSec += 30;
        GlobalEmeraldmine.numberOfEmeraldmines += 1;
    }
    public void StartAutoResource5()
    {
        playSound.Play();
        AutoResource5.SetActive(true);
        GlobalCash.CashCount -= GlobalDiamondmine.diamondmineValue;
        GlobalDiamondmine.diamondmineValue *= 2;
        GlobalDiamondmine.turnOffButton = true;
        GlobalDiamondmine.diamondminePerSec += 50;
        GlobalDiamondmine.numberOfDiamondmines += 1;
    }
}
