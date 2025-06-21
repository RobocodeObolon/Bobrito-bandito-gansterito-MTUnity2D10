using System.Collections;
using System.Collections.Generic;
using UnityEngine;

{
             public float timeLimit = 20f; 
             private float timeRemaining;
             private bool isGameOver = false;

             public Text timerText; 
              public GameObject gameOverUI; 

             void Start()
             {
                 timeRemaining = timeLimit;
                 UpdateTimerDisplay();
             }

            void Update()
            {
                if (isGameOver) return;
                 timeRemaining -= Time.deltaTime;

                  if (timeRemaining <= 0f)
              {
                  timeRemaining = 0f;
                  GameOver();
             }

                 UpdateTimerDisplay();
            }

                void UpdateTimerDisplay()
          {
                 if (timerText != null)
           {
              timerText.text = "Time Left: " + Mathf.CeilToInt(timeRemaining).ToString() + "s";
             }
    }   

         void GameOver()
     {
        isGameOver = true;
        Debug.Log("Time's up! Game Over.");

        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }
        }
    }
