using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    
    public AudioSource MineButton;
    public AudioSource SellButton;


    public void PlayMineButton()
    {
        MineButton.Play();
    }

    public void PlaySellButton()
    {
        SellButton.Play();
    }
}
