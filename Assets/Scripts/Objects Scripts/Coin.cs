using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Coin : MonoBehaviour//, IDataPersistence
{
    [SerializeField] CoinManager coinManager;
    [SerializeField] UIManager uiManager;
    [SerializeField] TextMeshProUGUI coinGatheredText;
    [SerializeField] AudioSource coinCollectedSound;

    private bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!collected && other.tag == "Player")
        {
            CoinCollected();
            Debug.Log("Collected");
        }
    }

    private void CoinCollected()
    {
        collected = true;
        coinCollectedSound.Play();
        uiManager.CoinGatheredTextPopUp();
        coinManager.coinsCollected++;        
        Destroy(this.gameObject);
    }


}
