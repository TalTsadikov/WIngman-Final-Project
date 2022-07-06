using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;
    [SerializeField] WingsuitController wsCon;

    private void OnTriggerEnter(Collider other)
    {
        if (cpManager.checkpointTriggered == 3)
        {
            Debug.Log("Won");
        }
        else
        {
            wsCon.SetRetryMenuActive();
        }
    }
}
