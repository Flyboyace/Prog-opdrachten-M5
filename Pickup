using UnityEngine;
using System;

public class Pickup : MonoBehaviour
{
    public static event Action<int> OnPickupCollected;    // voor score
    public static event Action<float, float> OnSpeedBoost; // voor speed: (factor, duration)

    [SerializeField] private int points = 50;
    [SerializeField] private float speedBoostFactor = 2f;   // 2x zo snel
    [SerializeField] private float speedBoostDuration = 5f; // 5 seconden

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Score event uitsturen
            OnPickupCollected?.Invoke(points);

            // Speed event uitsturen
            OnSpeedBoost?.Invoke(speedBoostFactor, speedBoostDuration);

            // Pickup verdwijnt
            Destroy(gameObject);
        }
    }
}
