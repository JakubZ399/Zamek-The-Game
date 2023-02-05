using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevelScript : MonoBehaviour
{
    //
    //debug
    //

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            LoadNextLevel();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReloadCurrentLevel();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenuButton();
        }
    }

    //
    //
    //
    public void LoadNextLevelAfterTime(float timeToLoad)
    {
        Cursor.lockState = CursorLockMode.Locked;
        Invoke("LoadNextLevel", timeToLoad);
    }
    public void LoadNextLevel()
    {
        //get active scene id
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;

        //load next level
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(nextScene);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReloadCurrentLevel()
    {
        //get active scene id
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int currentToReloadScene = currentScene - 1;

        SceneManager.LoadScene(currentToReloadScene);
    }

    public void QuitApp()
    {
        Application.Quit();
    }

    
}
