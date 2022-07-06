using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cpManager.checkpointTriggered++;
            Debug.Log("checkpoint");
        }
    }
}
