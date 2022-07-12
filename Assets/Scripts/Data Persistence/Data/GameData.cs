using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public int totalCoins;
    public int level1HighScore;
    public int level2HighScore;
    public int level3HighScore;

    public GameData()
    {
        totalCoins = new int();
        level1HighScore = new int();
        level2HighScore = new int();
        level3HighScore = new int();
    }
}
