using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevelScript : MonoBehaviour
{
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
}
