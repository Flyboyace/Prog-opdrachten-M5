using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float rotatespeed = 100f;
    void Update()
    {
        transform.Rotate(0f, rotatespeed * Time.deltaTime ,0f);
    }
}
