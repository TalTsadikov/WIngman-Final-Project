using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LevelSelectMenu : MonoBehaviour
{
    public const string MAIN_MENU = "Main Menu";

    [SerializeField] GameManager gameManager;
    [SerializeField] TextMeshProUGUI coinText;

    [SerializeField] Button level2Button;
    [SerializeField] Button level3Button;

    [SerializeField] GameObject level2Lock;
    [SerializeField] GameObject level3Lock;


    private void Start()
    {
        level2Button.interactable = false;
        level3Button.interactable = false;
    }

    private void Update()
    {
        coinText.text = "COINS:" + gameManager.totalCoins;

        if(gameManager.totalCoins >= 18)
        {
            level2Button.interactable = true;
            level2Lock.SetActive(false);
        }

        if(gameManager.totalCoins >= 44)
        {
            level3Button.interactable = true;
            level3Lock.SetActive(false);
        }
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
        SceneManager.LoadScene(3);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MAIN_MENU);
    }
}
