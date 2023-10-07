using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToBeContinuedButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMainMenu()
    {
        // we'll fake this for now since main menu doesn't exist yet
        SceneManager.LoadScene("Lobby");
    }

    public void QuitGame()
    {
        Debug.Log("application quitting...");
        Application.Quit();
    }
}
