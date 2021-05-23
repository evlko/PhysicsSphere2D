using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Sphere sphere;
    Transform transform;
    Rigidbody2D rb;
    void Start()
    {
        sphere = GetComponent<Sphere>();
        transform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Move object and draw speed vector
    void Update()
    {
        rb.velocity = new Vector2(sphere.hspeed, sphere.vspeed);
        sphere.DrawSpeed();
    }
}
