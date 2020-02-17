using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyAddForce : MonoBehaviour
{
    public float forceMultiplier = 200f;

    private Rigidbody rb;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * forceMultiplier * Time.deltaTime);
    }
}
