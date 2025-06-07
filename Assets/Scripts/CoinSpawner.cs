using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;      // ������ �������
    public float spawnInterval = 3f;   // �������� ������ � ��������
    public Vector2 spawnAreaMin;       // ̳������ ���������� ������ ������
    public Vector2 spawnAreaMax;       // ���������� ���������� ������ ������

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

