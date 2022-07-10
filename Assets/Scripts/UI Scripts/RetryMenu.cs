using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryMenu : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] Canvas retryMenu;
    public const string MAIN_MENU = "Main Menu";

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MAIN_MENU);
        Time.timeScale = 1;
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
