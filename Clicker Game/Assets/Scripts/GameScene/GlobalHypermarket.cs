using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHypermarket : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int hypermarketValue = 100000; //wartosc sklepu, 10 podczas testów domyślnie zmienić na 100000
    public static bool turnOffButton = false;
    public GameObject hypermarketStats;
    public static int numberOfHypermarkets;
    public static int hypermarketPerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        hypermarketStats.GetComponent<Text>().text = "Hypermarkets: " + numberOfHypermarkets + " @ " + hypermarketPerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Hypermarket - $" + hypermarketValue;
        realText.GetComponent<Text>().text = "Buy Hypermarket - $" + hypermarketValue;
        if (currentCash >= hypermarketValue)
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
