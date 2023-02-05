using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayLevelName : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI displayLevelName;

    private void Start()
    {
        displayLevelName.text = SceneManager.GetActiveScene().name;
    }
}
