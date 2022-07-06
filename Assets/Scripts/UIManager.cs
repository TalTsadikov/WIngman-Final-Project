using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] CheckPointManager cpManager;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI checkpointAmountText;
    public TextMeshProUGUI checkpointTriggeredText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "X" + ScoreManager.levelScore.ToString();
        checkpointTriggeredText.text = cpManager.checkpointTriggered.ToString();
        checkpointAmountText.text = "/" + cpManager.checkpointAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "X" + ScoreManager.levelScore.ToString(); 
        checkpointTriggeredText.text = cpManager.checkpointTriggered.ToString();
        checkpointAmountText.text = "/" + cpManager.checkpointAmount.ToString();
    }
}
