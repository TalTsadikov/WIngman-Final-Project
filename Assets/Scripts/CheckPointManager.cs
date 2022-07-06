using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public Transform[] checkpoints;
    public int checkpointAmount;
    public int checkpointTriggered;

    private void Start()
    {
        checkpoints = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            checkpoints[i] = transform.GetChild(i);
            checkpointAmount++;
        }
    }
}
