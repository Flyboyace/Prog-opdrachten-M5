using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector3 movement;

    private void OnEnable()
    {
        Pickup.OnSpeedBoost += ApplySpeedBoost;
    }

    private void OnDisable()
    {
        Pickup.OnSpeedBoost -= ApplySpeedBoost;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        movement = new Vector3(moveX, 0, moveZ);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void ApplySpeedBoost(float factor, float duration)
    {
        StopAllCoroutines(); // reset oude boosts
        StartCoroutine(SpeedBoostRoutine(factor, duration));
    }

    private System.Collections.IEnumerator SpeedBoostRoutine(float factor, float duration)
    {
        moveSpeed *= factor;
        yield return new WaitForSeconds(duration);
        moveSpeed /= factor;
    }
}
