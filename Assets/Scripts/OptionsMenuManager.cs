using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public const string volume = "musicVolume";

    void Start()
    {
        if (!PlayerPrefs.HasKey(volume))
        {
            PlayerPrefs.SetFloat(volume, 1);
            LoadVolume();
        }

        else
        {
            LoadVolume();
        }
    }

    public void changeVolume()
    {
        float volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat(volume, volumeValue);
        LoadVolume();
    }

    private void LoadVolume()
    {
        float volumeValue = PlayerPrefs.GetFloat(volume);
        volumeSlider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }

    public void FullScreenWindowMode()
    {
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, FullScreenMode.FullScreenWindow);
    }

    public void WindowedMode()
    {
        Screen.fullScreenMode = FullScreenMode.Windowed;
    }
}
