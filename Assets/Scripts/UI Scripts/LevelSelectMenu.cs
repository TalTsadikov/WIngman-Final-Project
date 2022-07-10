using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelectMenu : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public const string MAIN_MENU = "Main Menu";
    [SerializeField] TextMeshProUGUI coinText;

    private void Update()
    {
        coinText.text = "COINS:" + gameManager.totalCoins;
    }

    public void Level1Button()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2Button()
    {
        SceneManager.LoadScene(2);
    }

    public void Level3Button()
    {

    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MAIN_MENU);
    }
}
