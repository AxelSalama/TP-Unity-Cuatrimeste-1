﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpCubeScroll : MonoBehaviour
{
    public float scrollFactor = -1;
    public Vector3 gameVelocity;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = gameVelocity * scrollFactor;
    }

    void OnTriggerExit(Collider gameArea)
    {
        transform.position += Vector3.right * (gameArea.bounds.size.x + GetComponent<BoxCollider>().size.x);
    }

    void OnCollisionEnter(Collision other)
    {
        rb.velocity = gameVelocity * -1;
    }

    void OnCollisionStay(Collision other)
    {
        rb.velocity = gameVelocity * -1;
    }

    void OnCollisionExit(Collision other)
    {
        rb.velocity = gameVelocity * -1;
    }
}
