using System;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private Platform _platform;

    private void Awake()
    {
        _platform = GetComponentInParent<Platform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _platform.CompositeBounce(collision.rigidbody);
    }
}
