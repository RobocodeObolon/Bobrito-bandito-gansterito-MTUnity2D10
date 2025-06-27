using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimerDisplay : MonoBehaviour
{
    public float timeLeft = 20f;
    public TextMeshProUGUI timerText;
    public GameObject losePanel;

    void Start()
    {
        losePanel = GameObject.Find("losePanel");
        losePanel.SetActive(false);
    }
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time Left: " + Mathf.CeilToInt(timeLeft).ToString();
        }
        else
        {
            losePanel.SetActive(true);
            timerText.text = "TIME'S UP!";
            Time.timeScale = 0f;
        }
    }
}