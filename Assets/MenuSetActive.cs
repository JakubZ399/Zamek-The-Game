using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSetActive : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelMenu;
    public GameObject credtisMenu;

    public void MainMenu(bool isActive)
    {
        mainMenu.SetActive(isActive);
    }

    public void LevelMenu(bool isActive) 
    {
        levelMenu.SetActive(isActive);
    }

    public void CreditsMenu(bool isActive)
    {
        credtisMenu.SetActive(isActive);
    }
}
