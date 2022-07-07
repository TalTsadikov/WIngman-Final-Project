using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IDataPersistence
{
    [SerializeField] CoinManager coinManager;
    private bool collected = false;

    [SerializeField] private string id;
    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    public void LoadData(GameData data)
    {
        data.coinsCollected.TryGetValue(id, out collected);
        if (collected)
        {
            Destroy(this.gameObject);
        }
    }

    public void SaveData(GameData data)
    {
        if (data.coinsCollected.ContainsKey(id))
        {
            data.coinsCollected.Remove(id);
        }
        data.coinsCollected.Add(id, collected);
    }

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
        coinManager.coinCollected++;
        Destroy(this.gameObject);
    }
}
