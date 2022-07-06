using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public int checkpointTriggered;

    private void OnTriggerEnter(Collider other)
    {
        checkpointTriggered++;
        Debug.Log("checkpoint");
    }
}
