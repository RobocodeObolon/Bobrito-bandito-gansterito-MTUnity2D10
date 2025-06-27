using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;      // Префаб монетки
    public float spawnInterval = 3f;   // Інтервал спавну в секундах
    public Vector2 spawnAreaMin;       // Мінімальні координати області спавну
    public Vector2 spawnAreaMax;       // Максимальні координати області спавну

    void Start()
    {
        InvokeRepeating("SpawnCoin", 0f, spawnInterval);
    }

    void SpawnCoin()
    {
        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}

