using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TimerDefeat : MonoBehaviour
{
    public float timeLeft = 20f;

    void Start()
    {
        Time.timeScale = 1f; // ÂÀÆËÈÂÎ!
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0f)
        {
            Debug.Log("ÏÎÐÀÇÊÀ");
            Time.timeScale = 0f;
        }
    }
}