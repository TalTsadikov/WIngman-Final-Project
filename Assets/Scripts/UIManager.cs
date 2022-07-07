using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
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
        coinsCollectedText.text = scoreManager.levelScore.ToString();
        checkpointTriggeredText.text = cpManager.checkpointTriggered.ToString();
        checkpointAmountText.text = "/" + cpManager.checkpointAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinAmountText.text = "/" + coinManager.coinsAmount.ToString();
        coinsCollectedText.text = scoreManager.levelScore.ToString();
        checkpointTriggeredText.text = cpManager.checkpointTriggered.ToString();
        checkpointAmountText.text = "/" + cpManager.checkpointAmount.ToString();
    }
}
