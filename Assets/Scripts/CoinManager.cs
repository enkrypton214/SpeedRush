
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public CoinPickup coins;
    private int count;

    void Update()
    {
        count = coins.coinCount;
         displayText.text = "Coins:" + count.ToString();
    }
}
