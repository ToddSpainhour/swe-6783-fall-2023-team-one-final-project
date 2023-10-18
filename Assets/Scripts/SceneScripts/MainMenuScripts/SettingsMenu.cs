using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public MainMenu mainMenu;
    public GameObject settingsPanel;
    public GameObject playButton;
    public GameObject settingsButton;
    public GameObject quitButton;


    public void OnBackButtonClicked()
    {
        settingsPanel.SetActive(false); // Hide the settings panel
        playButton.SetActive(true); // Show the Play button
        settingsButton.SetActive(true); // Show the Settings button
        quitButton.SetActive(true); // Show the Quit button
    }

    //public void SetVolume(float volume)
    //{
    //    mainMenu.SetVolume(volume);
    //}
}
