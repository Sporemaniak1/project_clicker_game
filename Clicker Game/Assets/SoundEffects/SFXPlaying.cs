using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    
    public AudioSource MineButton;
    public AudioSource SellButton;
    public AudioSource ConstructionBuildingSiteSound;
    public AudioSource PauseMenuSounds;


    public void PlayMineButton()
    {
        MineButton.Play();
    }

    public void PlaySellButton()
    {
        SellButton.Play();
    }

    public void PlayConstructionBuildingSiteSound()
    {
        ConstructionBuildingSiteSound.Play();
    }

    public void PlayPauseMenuSounds()
    {
        PauseMenuSounds.Play();
    }

}
