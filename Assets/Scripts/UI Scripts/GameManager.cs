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
        level1HighScore = data.level1HighScore;
        level2HighScore = data.level2HighScore;
        level3HighScore = data.level3HighScore;
        level4HighScore = data.level4HighScore;
        level5HighScore = data.level5HighScore;
    }

    public void SaveData(GameData data)
    {
        data.level1HighScore = level1HighScore;
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
            else if (buildIndex == 4)
            {
                level4HighScore = level4Score;
            }
            else if (buildIndex == 5)
            {
                level5HighScore = level5Score;
            }
            finishLine.finishedLevel = false;
        }
    }
}
