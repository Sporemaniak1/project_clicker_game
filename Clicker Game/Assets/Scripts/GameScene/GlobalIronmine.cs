using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalIronmine : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int ironmineValue = 200; //wartosc kopalni, 200 podczas testów zmienić na 2000 na koniec
    public static bool turnOffButton = false;
    public GameObject ironmineStats;
    public static int numberOfIronmines;
    public static int ironminePerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        ironmineStats.GetComponent<Text>().text = "Ironmines: " + numberOfIronmines + " @ " + ironminePerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Ironmine - $" + ironmineValue;
        realText.GetComponent<Text>().text = "Buy Ironmine - $" + ironmineValue;
        if (currentCash >= ironmineValue)
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
