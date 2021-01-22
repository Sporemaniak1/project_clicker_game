using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalNickelmine : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int nickelmineValue = 20; //wartosc kopalni, 20 podczas testów zmienić na 20000 na koniec
    public static bool turnOffButton = false;
    public GameObject nickelmineStats;
    public static int numberOfNickelmines;
    public static int nickelminePerSec;
   
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        nickelmineStats.GetComponent<Text>().text = "Nickelmines: " + numberOfNickelmines + " @ " + nickelminePerSec + " Per Second ";
        fakeText.GetComponent<Text>().text = "Buy Nickelmine - $" + nickelmineValue;
        realText.GetComponent<Text>().text = "Buy Nickelmine - $" +nickelmineValue;
        if (currentCash >= nickelmineValue)
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
