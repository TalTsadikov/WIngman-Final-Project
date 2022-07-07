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

    public void LoadFirstScene()
    {
        DataPersistenceManager.instance.NewGame();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
