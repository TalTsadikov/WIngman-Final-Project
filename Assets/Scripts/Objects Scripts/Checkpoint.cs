using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;
    [SerializeField] UIManager uiManager;
    [SerializeField] TextMeshProUGUI checkpointReachedText;
    [SerializeField] AudioSource checkpointSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cpManager.checkpointTriggered++;
            Debug.Log("checkpoint");
            checkpointSound.Play();
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
