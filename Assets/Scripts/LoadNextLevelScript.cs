using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevelScript : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //get active scene id
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = currentScene + 1;

        //load next level
        SceneManager.LoadScene(nextScene);
    }
}
