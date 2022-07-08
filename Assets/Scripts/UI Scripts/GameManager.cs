using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour, IDataPersistence
{
    [SerializeField] FinishLine finishLine;
    [SerializeField] CoinManager coinManager;
    [SerializeField] ScoreManager scoreManager;
    public GameData data;
    public int level1Score;
    public int level2Score;
    public int level3Score;
    public int level4Score;
    public int level5Score;
    public int level1HighScore;
    public int level2HighScore;
    public int level3HighScore;
    public int level4HighScore;
    public int level5HighScore;
    public int buildIndex;
    public int levelHighScore;

    // Start is called before the first frame update
    void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadData(GameData data)
    {
        level1Score = data.level1HighScore;
        level2HighScore = data.level2HighScore;
        level3HighScore = data.level3HighScore;
        level4HighScore = data.level4HighScore;
        level5HighScore = data.level5HighScore;
    }

    public void SaveData(GameData data)
    {
        data.level1HighScore = level1Score;
        data.level2HighScore = level2HighScore;
        data.level3HighScore = level3HighScore;
        data.level4HighScore = level4HighScore;
        data.level5HighScore = level5HighScore;
    }

    // Update is called once per frame
    void Update()
    {
        if (finishLine.finishedLevel)
        {
            scoreManager.ScoreUpdater(coinManager.coinsCollected, scoreManager.LevelChecker(buildIndex));
            Debug.Log("Save");
            finishLine.finishedLevel = false;
        }
    }
}
