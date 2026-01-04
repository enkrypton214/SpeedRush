
using Unity.VisualScripting;
using UnityEngine;

public class SpikeCollision : MonoBehaviour
{
    // public AudioSource explosionSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Spike"))
        {
            // explosionSound.Play();
            transform.position = Vector3.zero;
        }
    }
}
