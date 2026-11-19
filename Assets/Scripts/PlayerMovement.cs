using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rigidbody2D;

    public void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        _rigidbody2D.linearVelocityX = speed;
    }


    private void OnCollisionEnter2D (Collision2D other)    {
        if (other.gameObject.tag == "Wall")
        {
            speed *= -1;
        }
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            _rigidbody2D.gravityScale = 1;
            speed = 0;
        }
    }
}

