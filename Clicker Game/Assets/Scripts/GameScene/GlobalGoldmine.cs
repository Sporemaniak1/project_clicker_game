using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalGoldmine : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int goldmineValue = 50; //wartosc kopalni, 50 podczas testów zmienić na 500 na koniec
    public static bool turnOffButton = false;
    public GameObject goldmineStats;
    public static int numberOfGoldmines;
    public static int goldminePerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        goldmineStats.GetComponent<Text>().text = "Goldmines: " + numberOfGoldmines + " @ " + goldminePerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Goldmine - $" + goldmineValue;
        realText.GetComponent<Text>().text = "Buy Goldmine - $" + goldmineValue;
        if (currentCash >= goldmineValue)
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
