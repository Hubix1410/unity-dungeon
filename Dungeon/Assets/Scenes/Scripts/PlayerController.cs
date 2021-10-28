using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Camera cam;

    public Vector2 moveDirection;
    public Vector2 mousePos;

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
        Aim();
    }

    void ProcessInputs()
    {
        // Move Inputs
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);
    }

    void Move()
    {
        // Move player
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;

        // Move cursor
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void Aim()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
    }
}
