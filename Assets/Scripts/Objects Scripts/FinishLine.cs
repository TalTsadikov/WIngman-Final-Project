using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;
    [SerializeField] WingsuitController wsCon;
    [SerializeField] GameObject winMenu;
    [SerializeField] AudioSource winSound;
    [SerializeField] AudioSource loseSound;

    public bool finishedLevel = false;

    private void OnTriggerEnter(Collider other)
    {
        if (cpManager.checkpointTriggered == cpManager.checkpointAmount)
        {
            finishedLevel = true;
            winSound.Play();
            SetWinMenuActive();
        }
        else
        {
            finishedLevel = false;
            loseSound.Play();
            wsCon.SetRetryMenuActive();
        }
    }

    public void SetWinMenuActive()
    {
        Time.timeScale = 0f;
        winMenu.SetActive(true);
    }
}
