using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public int firstTime;
    public GameObject tutorialScreen;

    void Start()
    {
        firstTime = PlayerPrefs.GetInt("firstTime");
        if (firstTime == 0) 
        {
            tutorialScreen.SetActive(true);
            Time.timeScale = 0f;
            PlayerPrefs.SetInt("firstTime", 1);
            Debug.Log("First");
        }
        else
        {
            tutorialScreen.SetActive(false);
            Debug.Log("Not First");
        }
    }

    public void CloseTutorialMenu()
    {
        tutorialScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
