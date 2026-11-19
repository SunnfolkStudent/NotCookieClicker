using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rigidbody2D;
    public GameObject Ball;
    private Transform _transform;

    private Vector2 _spawnPosition;
    

    public void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _transform = GetComponent<Transform>();
        
        
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
        _spawnPosition.y = _transform.position.y + -1f;
        _spawnPosition.x = _transform.position.x;
        
        
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(Ball, _spawnPosition , Quaternion.identity);
        }
    }
}

