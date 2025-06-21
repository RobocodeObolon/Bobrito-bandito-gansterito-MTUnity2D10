using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerDisplay : MonoBehaviour
{
    public float timeLeft = 20f;
    public Text timerText; 

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = "Time Left: " + Mathf.CeilToInt(timeLeft).ToString();
        }
        else
        {
            timerText.text = "TIME'S UP!";
            Time.timeScale = 0f;
        }
    }
}