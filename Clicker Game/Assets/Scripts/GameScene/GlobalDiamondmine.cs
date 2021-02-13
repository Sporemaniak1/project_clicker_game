using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDiamondmine : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int diamondmineValue = 10000; //wartosc kopalni, 1000 podczas testów zmienić na 10000 na koniec
    public static bool turnOffButton = false;
    public GameObject diamondmineStats;
    public static int numberOfDiamondmines;
    public static int diamondminePerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        diamondmineStats.GetComponent<Text>().text = "Diamondmines: " + numberOfDiamondmines + " @ " + diamondminePerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Diamondmine - $" + diamondmineValue;
        realText.GetComponent<Text>().text = "Buy Diamondmine - $" + diamondmineValue;
        if (currentCash >= diamondmineValue)
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
