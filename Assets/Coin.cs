using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1; // Скільки дає монетка
    public static int totalCoins = 0; // Загальний лічильник

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Збільшуємо лічильник
            totalCoins += value;

            // Виводимо в консоль (можна пізніше підключити UI)
            Debug.Log("Монетка підібрана! Загалом: " + totalCoins);

            // Знищити монетку
            Destroy(gameObject);
        }
    }
}