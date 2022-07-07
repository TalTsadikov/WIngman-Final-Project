using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;
    public static int totalScore = 0;
    public int levelScore = 0;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        levelScore = coinManager.coinCollected;
    }

    private void Update()
    {
        levelScore = coinManager.coinCollected;
    }
}
