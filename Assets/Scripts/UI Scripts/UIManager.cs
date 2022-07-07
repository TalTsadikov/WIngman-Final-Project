using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour ,IDataPersistence
{
    [SerializeField] CheckPointManager cpManager;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] CoinManager coinManager;
    public TextMeshProUGUI coinsCollectedText;
    public TextMeshProUGUI coinAmountText;
    public TextMeshProUGUI checkpointAmountText;
    public TextMeshProUGUI checkpointTriggeredText;

    // Start is called before the first frame update
    void Start()
    {
        coinAmountText.text = "/" + coinManager.coinsAmount.ToString();
        coinsCollectedText.text = coinManager.coinCollected.ToString();
        checkpointTriggeredText.text = cpManager.checkpointTriggered.ToString();
        checkpointAmountText.text = "/" + cpManager.checkpointAmount.ToString();
    }

    public void LoadData(GameData data)
    {
        foreach (KeyValuePair<string, bool> pair in data.coinsCollected)
        {
            if (pair.Value)
            {
                coinManager.coinCollected++;
            }
        }
    }

    public void SaveData(GameData data)
    {

    }
    // Update is called once per frame
    void Update()
    {
        coinAmountText.text = "/" + coinManager.coinsAmount.ToString();
        coinsCollectedText.text = coinManager.coinCollected.ToString();
        checkpointTriggeredText.text = cpManager.checkpointTriggered.ToString();
        checkpointAmountText.text = "/" + cpManager.checkpointAmount.ToString();
    }
}
