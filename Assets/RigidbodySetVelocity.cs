using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodySetVelocity : MonoBehaviour
{
    private Rigidbody rb;

    private float forceMulitplier = 200;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * Time.deltaTime * forceMulitplier;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
