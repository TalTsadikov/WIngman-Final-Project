using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] CoinManager coinManager;
    [SerializeField] GameManager gameManager;
    public static int totalScore = 0;
    private string level;

    public void ScoreUpdater(int coinsCollected, string levelNumHighScore)
    {
        switch (levelNumHighScore)
        {
            case "level1HighScore":
                if (coinsCollected > gameManager.level1HighScore)
                {
                    gameManager.level1Score = coinsCollected;
                    Debug.Log("1");
                }
                break;
            case "level2HighScore":
                if (coinsCollected > gameManager.level2HighScore)
                {
                    gameManager.level2Score = coinsCollected;
                    Debug.Log("2");
                }
                break;
            case "level3HighScore":
                if (coinsCollected > gameManager.level3HighScore)
                {
                    gameManager.level3Score = coinsCollected;
                    Debug.Log("3");
                }
                break;
            default:
                break;
        }
    }

    public string LevelChecker(int buildIndex)
    {
        switch (buildIndex)
        {
            case 1:
                level = "level1HighScore";
                break;
            case 2:
                level = "level2HighScore";
                break;
            case 3:
                level = "level3HighScore";
                break;
        }

        return level;
    }
}
