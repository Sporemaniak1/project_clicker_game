using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoSell;
    public GameObject AutoSell1;
    public GameObject AutoSell2;
    public AudioSource playSound;
    public GameObject AutoResource;
    public GameObject AutoResource2;
    public GameObject AutoResource3;
    public GameObject AutoResource4;
    public GameObject AutoResource5;
    public GameObject AutoResource6;

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
    public void StartAutoSell1()
    {
        playSound.Play();
        AutoSell1.SetActive(true);
        GlobalCash.CashCount -= GlobalMarket.marketValue;
        GlobalMarket.marketValue *= 2; //mnoznik wartosci surowcow z kopalni
        GlobalMarket.turnOffButton = true;
        GlobalMarket.marketPerSec += 30;
        GlobalMarket.numberOfMarkets += 1;
    }
    public void StartAutoSell2()
    {
        playSound.Play();
        AutoSell2.SetActive(true);
        GlobalCash.CashCount -= GlobalSupermarket.supermarketValue;
        GlobalSupermarket.supermarketValue *= 2; //mnoznik wartosci surowcow z kopalni
        GlobalSupermarket.turnOffButton = true;
        GlobalSupermarket.supermarketPerSec += 70;
        GlobalSupermarket.numberOfSupermarkets += 1;
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
    public void StartAutoResource6()
    {
        playSound.Play();
        AutoResource6.SetActive(true);
        GlobalCash.CashCount -= GlobalNickelmine.nickelmineValue;
        GlobalNickelmine.nickelmineValue *= 2;
        GlobalNickelmine.turnOffButton = true;
        GlobalNickelmine.nickelminePerSec += 80;
        GlobalNickelmine.numberOfNickelmines += 1;
    }
}
