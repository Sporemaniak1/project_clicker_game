using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSupermarket : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int supermarketValue = 10000; //wartosc sklepu, 10 podczas testów domyślnie zmienić na 10000
    public static bool turnOffButton = false;
    public GameObject supermarketStats;
    public static int numberOfSupermarkets;
    public static int supermarketPerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        supermarketStats.GetComponent<Text>().text = "Supermarkets: " + numberOfSupermarkets + " @ " + supermarketPerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Supermarket - $" + supermarketValue;
        realText.GetComponent<Text>().text = "Buy Supermarket - $" + supermarketValue;
        if (currentCash >= supermarketValue)
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
