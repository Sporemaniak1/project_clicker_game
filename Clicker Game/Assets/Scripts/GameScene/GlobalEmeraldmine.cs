using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalEmeraldmine : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int emeraldmineValue = 500; //wartosc kopalni, 500 podczas testów zmienić na 5000 na koniec
    public static bool turnOffButton = false;
    public GameObject emeraldmineStats;
    public static int numberOfEmeraldmines;
    public static int emeraldminePerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        emeraldmineStats.GetComponent<Text>().text = "Emeraldmines: " + numberOfEmeraldmines + " @ " + emeraldminePerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Emeraldmine - $" + emeraldmineValue;
        realText.GetComponent<Text>().text = "Buy Emeraldmine - $" + emeraldmineValue;
        if (currentCash >= emeraldmineValue)
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
