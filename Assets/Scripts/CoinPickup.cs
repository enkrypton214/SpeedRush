using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public  int coinCount;
    // public AudioSource CoinSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // CoinSound.Play();
            other.gameObject.SetActive(false);
            coinCount+=100;
        }
    }
}
