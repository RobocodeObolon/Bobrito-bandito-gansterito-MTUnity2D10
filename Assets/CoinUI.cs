using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    void Update()
    {
        // ������� ������� ����� � ���������
        coinText.text = "������: " + Coin.totalCoins;
    }
}
