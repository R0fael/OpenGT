using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Object : MonoBehaviour
{

    public bool isDebugging;

    public Vector3 velocity = Vector3.zero;
    public bool isStopped;


    public Force[] forces;

    private Rigidbody rb;
    private bool isUsingGravity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        isUsingGravity = rb.useGravity;
    }
    void Update()
    {
        if (isStopped)
        {
            if(velocity == Vector3.zero) {
                velocity = rb.velocity;
            }
            rb.velocity = Vector3.zero;
            rb.useGravity = false;
        }
        else
        {
            if(velocity != Vector3.zero)
            {
                rb.useGravity = isUsingGravity;
                rb.velocity = velocity;
                velocity = Vector3.zero;
            }
        }
    }
    // DO NOT READ IT WILL HURT YOUR EYES
    private void OnTriggerEnter(Collider other)
    {
        foreach (Force force in forces) {
            if(other.CompareTag(force.name))
            {
                Affect(force);
            }
        }
    }

    public void Affect(Force force)
    {
        if (isDebugging)
        {
            Debug.Log(gameObject.name + " was affected by force " + force.name);
        }
        rb.velocity *= force.velocityBump;
        rb.AddForce(force.force);
        if (force.isTimeStop) { isStopped = force.TimeStopState; }

        if (force.isGravityChange) { isUsingGravity = force.GravityChangeState; rb.useGravity = force.GravityChangeState; }

        if (force.material != null) { GetComponent<Renderer>().material = force.material; }
        if (force.physicMaterial != null) { GetComponent<Collider>().material = force.physicMaterial; }
    }
}
