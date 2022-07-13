using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IDataPersistence
{
    [SerializeField] FinishLine finishLine;
    [SerializeField] CoinManager coinManager;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] GameObject tutorialMenu;
    public GameData data;
    public int level1Score;
    public int level2Score;
    public int level3Score;
    public int level1HighScore;
    public int level2HighScore;
    public int level3HighScore;
    public int totalCoins;
    public int buildIndex;

    // Start is called before the first frame update
    void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadData(GameData data)
    {
        level1HighScore = data.level1HighScore;
        level2HighScore = data.level2HighScore;
        level3HighScore = data.level3HighScore;
        totalCoins = data.totalCoins;
    }

    public void SaveData(GameData data)
    {
        data.level1HighScore = level1HighScore;
        data.level2HighScore = level2HighScore;
        data.level3HighScore = level3HighScore;
        data.totalCoins = totalCoins;
    }

    // Update is called once per frame
    void Update()
    {
        if (finishLine.finishedLevel)
        {
            scoreManager.ScoreUpdater(coinManager.coinsCollected, scoreManager.LevelChecker(buildIndex));
            Debug.Log("Save");
            if (buildIndex == 1)
            {
                level1HighScore = level1Score;
                Debug.Log("Save1");
            }
            else if(buildIndex == 2)
            {
                Debug.Log("Save2");
                level2HighScore = level2Score;
            }
            else if (buildIndex == 3)
            {
                level3HighScore = level3Score;
            }
            
            SumUpTotalCoins();

            finishLine.finishedLevel = false;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            tutorialMenu.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void SumUpTotalCoins()
    {
        totalCoins = level1HighScore + level2HighScore + level3HighScore;
    }
}
