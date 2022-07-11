using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public const string MAIN_MENU = "Main Menu";
    int currentSceneIndex;

    public void NextLevelButton()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex++);
        Time.timeScale = 1;
        DataPersistenceManager.instance.SaveGame();
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MAIN_MENU);
        Time.timeScale = 1;
        DataPersistenceManager.instance.SaveGame();
    }

    public void ReplayLevelButton()
    {
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
        DataPersistenceManager.instance.SaveGame();
    }
}
