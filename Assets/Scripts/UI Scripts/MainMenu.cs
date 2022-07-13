using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    public void LevelSelectButton()
    {
        if(gameManager.totalCoins == 0)
        {
            DataPersistenceManager.instance.NewGame();
        }
        SceneManager.LoadScene("Level Select Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
