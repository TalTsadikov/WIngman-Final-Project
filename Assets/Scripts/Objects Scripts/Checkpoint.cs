using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;
    [SerializeField] UIManager uiManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cpManager.checkpointTriggered++;
            Debug.Log("checkpoint");
            uiManager.CheckPointReachedTextEnable();
            StartCoroutine(CPTextDisableTimer());
        }
    }

    IEnumerator CPTextDisableTimer()
    {
        yield return new WaitForSeconds(1f);
        uiManager.CheckPointReachedTextDisable();
    }
}
