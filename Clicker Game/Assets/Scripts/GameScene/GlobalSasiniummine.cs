using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalSasiniummine : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int SasiniummineValue = 70; //wartosc kopalni, 70 podczas testów zmienić na 70000000 na koniec
    public static bool turnOffButton = false;
    public GameObject sasiniummineStats;
    public static int numberOfSasiniummines;
    public static int sasiniumminePerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        sasiniummineStats.GetComponent<Text>().text = "Sasiniummines: " + numberOfSasiniummines + " @ " +sasiniumminePerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Sasiniummine - $" + SasiniummineValue;
        realText.GetComponent<Text>().text = "Buy Sasiniummine - $" + SasiniummineValue;
        if (currentCash >= SasiniummineValue)
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
