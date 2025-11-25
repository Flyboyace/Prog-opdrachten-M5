using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Beweeg de enemy vooruit langs de lokale Z-as
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
