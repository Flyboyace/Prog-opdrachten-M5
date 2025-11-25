using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ballshooter : MonoBehaviour
{
    [SerializeField] private Vector3 initialvelocity = new Vector3(8f, 0f, 0f);

    private Rigidbody rb;
    void Awake() { rb = GetComponent<Rigidbody>(); }
    void AWake() { rb.linearVelocity = initialvelocity; }


    void Start()
    {
        transform.position = initialvelocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
