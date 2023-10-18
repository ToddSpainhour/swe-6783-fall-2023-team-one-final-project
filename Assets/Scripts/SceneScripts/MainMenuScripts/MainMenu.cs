using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject playButton;
    public GameObject settingsButton;
    public GameObject quitButton;

    public AudioManager audioManager;
    public Slider volumeSlider;

    private void Start()
    {
        //Load saved volume level or set default (1.0f)
        //volumeSlider.value = audioManager.GameVolume;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void QuitGame()
    {
        Debug.Log("quitting game...");
        Application.Quit();
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        playButton.SetActive(false); // Hide the Play button
        settingsButton.SetActive(false); // Hide the Settings button
        quitButton.SetActive(false); // Hide the Quit button
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        playButton.SetActive(true); // Show the Play button
        settingsButton.SetActive(true); // Show the Settings button
        quitButton.SetActive(true); // Show the Quit button
    }

    //public void SetVolume(float volume)
    //{
    //    //audioManager.GameVolume = volume;//sets the volume for any audio clips in the game
    //}
}
