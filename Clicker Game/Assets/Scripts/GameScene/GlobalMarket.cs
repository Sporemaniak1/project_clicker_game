using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMarket : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int marketValue = 1000; //wartosc sklepu, 10 podczas testów domyślnie zmienić na 1000
    public static bool turnOffButton = false;
    public GameObject marketStats;
    public static int numberOfMarkets;
    public static int marketPerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        marketStats.GetComponent<Text>().text = "Markets: " + numberOfMarkets + " @ " + marketPerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Market - $" + marketValue;
        realText.GetComponent<Text>().text = "Buy Market - $" + marketValue;
        if (currentCash >= marketValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else
        {
            turnOffButton = true;
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }

    }
}
