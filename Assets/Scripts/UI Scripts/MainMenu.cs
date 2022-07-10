using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

   //private void Start()
   //{
   //    if (!DataPersistenceManager.instance.HasGameData())
   //    {
   //        //disable future continue button
   //    }
   //}

    public void LevelSelectButton()
    {
        if(gameManager.totalCoins == 0)
        {
            DataPersistenceManager.instance.NewGame();
        }

        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
