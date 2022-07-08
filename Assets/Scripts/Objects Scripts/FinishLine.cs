using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;
    [SerializeField] WingsuitController wsCon;
    [SerializeField] GameObject winMenu;

    public bool finishedLevel = false;

    private void OnTriggerEnter(Collider other)
    {
        if (cpManager.checkpointTriggered == 3)
        {
            finishedLevel = true;
            SetWinMenuActive();
        }
        else
        {
            finishedLevel = false;
            wsCon.SetRetryMenuActive();
        }
    }

    public void SetWinMenuActive()
    {
        Time.timeScale = 0f;
        winMenu.SetActive(true);
    }
}
