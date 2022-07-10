using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   //private void Start()
   //{
   //    if (!DataPersistenceManager.instance.HasGameData())
   //    {
   //        //disable future continue button
   //    }
   //}

    public void LevelSelectButton()
    {
        //if(currentCoins != 0)
        //{
        //    DataPersistenceManager.instance.NewGame();
        //}

        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
