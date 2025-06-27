using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCheker : MonoBehaviour
{
    private GameObject winPanel;
    public PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        winPanel = GameObject.Find("winPanel");
        winPanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {



        if (player.coinsCollected >= player.coinsToWin)
        {
            winPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
