using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cod : MonoBehaviour
{
    private GameObject MainMenuPanel;
    private Button PlayButton;
    private Button SettingsButton;
    private Button QuitButton;

    private GameObject PlayMenuPanel;
    private Button BackButton1;
    private Button Level1;

    private GameObject SettingsMenuPanel;
    private Button BackButton2;
    private void Awake()
    {
        MainMenuPanel = GameObject.Find("MainMenuPanel");
        QuitButton = GameObject.Find("QuitButton").GetComponent<Button>();
        PlayButton = GameObject.Find("PlayButton").GetComponent<Button>();
        SettingsButton = GameObject.Find("SettingsButton").GetComponent<Button>();

        PlayMenuPanel = GameObject.Find("PlayMenuPanel");
        BackButton1 = GameObject.Find("BackButton1").GetComponent<Button>();
        Level1 = GameObject.Find("Level1").GetComponent<Button>();


        SettingsMenuPanel = GameObject.Find("SettingsMenuPanel");
        BackButton2 = GameObject.Find("BackButton2").GetComponent<Button>();
    }
    private void Start()
    {
        MainMenuPanel.SetActive(true);
        PlayMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(false);

        QuitButton.onClick.AddListener(QuitGame);
        PlayButton.onClick.AddListener(OpenPlayMenu);
        SettingsButton.onClick.AddListener(PlaySettingsMenu);
        BackButton1.onClick.AddListener(BackToMainMenu);
        Level1.onClick.AddListener(OpenLevel1);

        BackButton2.onClick.AddListener(BackToMainMenuu);

    }

    #region OYNA MENUSU
    private void OpenLevel1() 
    {
        SceneManager.LoadScene(1);
    }
   

    private void BackToMainMenu()
    {
        MainMenuPanel.SetActive(true);
        PlayMenuPanel.SetActive(false);
    }
    #endregion

    #region AYARLAR MENU
    private void BackToMainMenuu()
    {
        MainMenuPanel.SetActive(true);
       SettingsMenuPanel.SetActive(false);
    }

    #endregion

    #region ANA MENU PANEL
    private void PlaySettingsMenu()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(true);
    }

    private void OpenPlayMenu()
    {
        MainMenuPanel.SetActive(false);
        PlayMenuPanel.SetActive(true);
    }


    private void QuitGame()
    {
        Application.Quit();
    }
    #endregion
}

