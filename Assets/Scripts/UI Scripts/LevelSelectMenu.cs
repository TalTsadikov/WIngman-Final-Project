using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.UI;
using TMPro;

public class LevelSelectMenu : MonoBehaviour
{
    public const string MAIN_MENU = "Main Menu";
    [SerializeField] TextMeshProUGUI coinText;

    private void Update()
    {
        //coinText.text = "CURRENT COINS:" + currentCoins;
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
