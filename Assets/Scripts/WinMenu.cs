using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public const string MAIN_MENU = "Main Menu";
    int currentSceneIndex;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene(currentSceneIndex++);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MAIN_MENU);
    }

    public void ReplayLevelButton()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}
