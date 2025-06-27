
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

               

                Destroy(gameObject);
            }
        }
    }
}

