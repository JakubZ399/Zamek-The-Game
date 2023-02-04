using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Timer : LoadNextLevelScript
{
    [SerializeField] GameObject noClickPanel;
    public float timeValue = 120;
    public TextMeshProUGUI timerText;

    private void Start()
    {
        noClickPanel.SetActive(false);
        timerText = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if(timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
            Debug.Log("LOAD LEVEL");
            noClickPanel.SetActive(true);
            LoadNextLevelAfterTime(3f);
        }
        else if (timeToDisplay > 0)
        {
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
