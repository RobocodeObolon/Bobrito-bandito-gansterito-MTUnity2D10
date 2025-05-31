using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1; // ������ �� �������
    public static int totalCoins = 0; // ��������� ��������

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // �������� ��������
            totalCoins += value;

            // �������� � ������� (����� ����� ��������� UI)
            Debug.Log("������� �������! �������: " + totalCoins);

            // ������� �������
            Destroy(gameObject);
        }
    }
}