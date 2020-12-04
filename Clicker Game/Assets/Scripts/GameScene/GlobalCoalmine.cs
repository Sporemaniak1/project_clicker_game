using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoalmine : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int coalmineValue = 50;
    public static bool turnOffButton = false;
    public GameObject coalmineStats;
    public static int numberOfCoalmines;
    public static int coalminePerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        coalmineStats.GetComponent<Text>().text = "Coalmines: " + numberOfCoalmines + " @ " + coalminePerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Coalmine - $" + coalmineValue;
        realText.GetComponent<Text>().text = "Buy Coalmine - $" + coalmineValue;
        if (currentCash >= coalmineValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
