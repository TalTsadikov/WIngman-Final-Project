using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    [SerializeField] RectTransform pauseMenuRect;
    [HideInInspector] public static bool isPaused;
    public const string MAIN_MENU = "Main Menu";

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        pauseMenuRect.DOAnchorPos(Vector2.zero, 0.5f);
        StartCoroutine(TimeFreezeActiveDelay());
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenuRect.DOAnchorPos(new Vector2(0, 1000), 1f);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        DataPersistenceManager.instance.SaveGame();
        SceneManager.LoadScene(MAIN_MENU);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator TimeFreezeActiveDelay()
    {
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0f;
    }

 
}
