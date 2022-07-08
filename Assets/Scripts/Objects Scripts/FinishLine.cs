using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;
    [SerializeField] WingsuitController wsCon;
    [SerializeField] GameObject winMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (cpManager.checkpointTriggered == 3)
        {
            SetWinMenuActive();
        }
        else
        {
            wsCon.SetRetryMenuActive();
        }
    }

    public void SetWinMenuActive()
    {
        Time.timeScale = 0f;
        winMenu.SetActive(true);
    }
}
