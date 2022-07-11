using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] CoinManager coinManager;
    public TextMeshProUGUI coinsCollectedText;
    public TextMeshProUGUI coinAmountText;
    public TextMeshProUGUI checkpointAmountText;
    public TextMeshProUGUI checkpointTriggeredText;
    public TextMeshProUGUI checkPointReachedText;

    // Start is called before the first frame update
    void Start()
    {
        coinAmountText.text = "/" + coinManager.coinsAmount.ToString();
        coinsCollectedText.text = coinManager.coinsCollected.ToString();
        checkpointTriggeredText.text = cpManager.checkpointTriggered.ToString();
        checkpointAmountText.text = "/" + cpManager.checkpointAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinAmountText.text = "/" + coinManager.coinsAmount.ToString();
        coinsCollectedText.text = coinManager.coinsCollected.ToString();
        checkpointTriggeredText.text = cpManager.checkpointTriggered.ToString();
        checkpointAmountText.text = "/" + cpManager.checkpointAmount.ToString();
    }

    public void CheckPointReachedTextEnable()
    {
        checkPointReachedText.DOFade(1, 1f);
        checkPointReachedText.transform.DOScale(2, 1f);        
    }

    public void CheckPointReachedTextDisable()
    {
        checkPointReachedText.transform.DOScale(1, 1f);
        checkPointReachedText.DOFade(0, 1f);
    }




}
