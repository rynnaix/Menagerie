using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuNavigator : MonoBehaviour
{
    [SerializeField] private ScreenSwitcher screenSwitcher;
    
    //Main Menu
    [SerializeField] private Button optionsButton;
    [SerializeField] private Button quitButton;
    //Settings Menu
    [SerializeField] private Button optionsBackToMainMenuButton;
    //Selection Menu
    [SerializeField] private Button aboutButton;
    [SerializeField] private Button startRaceButton;
    [SerializeField] private Button loadButton;
    [SerializeField] private Button helpButton;
    
    [SerializeField] private String gameplaySceneName = "Gameplay";


    private void Awake()
    {
        optionsButton.onClick.AddListener(() => screenSwitcher.SwitchScreen(ScreenTypes.Options));
        //setupRaceButton.onClick.AddListener(() => screenSwitcher.SwitchScreen(ScreenTypes.Selection));
        optionsBackToMainMenuButton.onClick.AddListener(() => screenSwitcher.SwitchScreen(ScreenTypes.Menu));
        //selectionBackToMainMenuButton.onClick.AddListener(() => screenSwitcher.SwitchScreen(ScreenTypes.Menu));
        //startRaceButton.onClick.AddListener(() => SceneManager.LoadScene(gameplaySceneName));
    }
}