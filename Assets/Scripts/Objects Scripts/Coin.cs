using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour//, IDataPersistence
{
    [SerializeField] CoinManager coinManager;
    private bool collected = false;

   //[SerializeField] private string id;
   //[ContextMenu("Generate guid for id")]
   //private void GenerateGuid()
   //{
   //    id = System.Guid.NewGuid().ToString();
   //}

  // public void LoadData(GameData data)
  // {
  //     coinManager.coinsCollected = data.coinsCollected;
  // }
  //
  // public void SaveData(GameData data)
  // {
  //     data.coinsCollected = coinManager.coinsCollected;
  // }

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
