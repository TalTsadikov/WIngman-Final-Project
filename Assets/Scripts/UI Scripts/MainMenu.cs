using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public const string LEVEL_SELECT_MENU = "Level Select Menu";

    public void LevelSelectButton()
    {
        if(gameManager.totalCoins == 0)
        {
            DataPersistenceManager.instance.NewGame();
        }
        SceneManager.LoadScene(LEVEL_SELECT_MENU);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
