
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameObject winPanel; // це об'єкт, який треба увімкнути (наприклад, вікно перемоги)
     void Start()
    {
        winPanel = GameObject.Find("winPanel");
        winPanel.SetActive(false);
    }
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
                    winPanel.SetActive(true);
                }

                Destroy(gameObject);
            }
        }
    }
}

