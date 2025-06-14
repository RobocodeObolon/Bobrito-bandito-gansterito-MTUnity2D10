using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    void Update()
    {
        // Постійно оновлює текст з лічильника
        coinText.text = "Монети: " + GetComponent<PlayerMovement>().coinsCollected;
    }
}
