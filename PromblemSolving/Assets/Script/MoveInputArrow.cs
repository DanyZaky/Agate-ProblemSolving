using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInputArrow : MonoBehaviour
{
    Rigidbody2D Rb;
    public float speed = 10;
    Vector2 MoveDirection;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        MoveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        Rb.velocity = new Vector2(MoveDirection.x * speed, MoveDirection.y * speed);
    }
}
