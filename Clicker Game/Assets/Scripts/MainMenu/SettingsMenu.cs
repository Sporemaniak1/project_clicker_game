using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    void Start () // rozdzielczosc
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>(); // lista rozdzielczosci

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++) // skrypt wczytujacy mozliwe rozdzielczosci poprzez unity
        {
            string option = resolutions[i].width +" x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options); // tworzy wybory rozdzielczosci
        resolutionDropdown.value = currentResolutionIndex; // sczytuje mozliwe rozdzielczosci
        resolutionDropdown.RefreshShownValue(); // czysci opcje by sie nie powtarzaly
    }

    public void SetResolution (int resolutionIndex) // funkcja rozdzielczosci w programie
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetVolume (float volume) // funkcja glosnosci dzwieku w programie
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetQuality (int qualityIndex) // funkcja jakosci grafiki w programie
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullscreen) // funkcja pelnego ekranu w programie
    {
        Screen.fullScreen = isFullscreen;
    }
}
