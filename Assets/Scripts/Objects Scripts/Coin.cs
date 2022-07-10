using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour//, IDataPersistence
{
    [SerializeField] CoinManager coinManager;
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
        coinManager.coinsCollected++;
        Destroy(this.gameObject);
    }
}
