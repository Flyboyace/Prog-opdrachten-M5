using UnityEngine;

public class Tower : MonoBehaviour
{
    void Start()
    {
        RandomizeSize();
    }

    private void RandomizeSize()
    {
        float randomHeight = Random.Range(0.5f, 3f);   // random hoogte
        float randomWidth = Random.Range(0.5f, 1.5f);  // random breedte

        transform.localScale = new Vector3(randomWidth, randomHeight, randomWidth);
    }
}
