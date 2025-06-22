using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TImer : MonoBehaviour
{
    private float timeLeft = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0f)
        {
            Time.timeScale = 0;
        }
    }
}
