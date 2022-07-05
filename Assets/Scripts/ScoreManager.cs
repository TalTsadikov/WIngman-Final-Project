using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int totalScore = 0;
    public static int levelScore = 0;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        scoreText.text = "X" + levelScore.ToString();
    }

    private void Update()
    {
        scoreText.text = "X" + levelScore.ToString();
    }
}
