using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public Transform[] coins;
    public int coinsAmount;
    public int coinCollected;

    private void Start()
    {
        coins = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            coins[i] = transform.GetChild(i);
            coinsAmount++;
        }
    }
}
