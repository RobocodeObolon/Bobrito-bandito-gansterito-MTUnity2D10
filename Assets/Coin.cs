
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();

            if (player != null)
            {
                player.coinsCollected++;
                Debug.Log("Coins collected: " + player.coinsCollected);

                if (player.coinsCollected >= player.coinsToWin)
                {
                    Debug.Log("YOU WIN!");
                }

                Destroy(gameObject);
            }
        }
    }
}


public class CoinCounter : MonoBehaviour
{
    public GameObject winScreen; // —юди перет€гни тв≥й WinScreen Image у ≥нспектор≥
    private int coinsCollected = 0;
    private int coinsToWin = 10;

    void Start()
    {
        winScreen.SetActive(false); // ’оваЇмо на початку
    }

    public void CollectCoin()
    {
        coinsCollected++;
        Debug.Log("Coins collected: " + coinsCollected);

        if (coinsCollected >= coinsToWin)
        {
            Debug.Log("You Win");
            ShowWinScreen();
        }
    }

    void ShowWinScreen()
    {
        winScreen.SetActive(true);
    }
}

