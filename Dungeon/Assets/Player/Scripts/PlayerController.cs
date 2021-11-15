using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed;

    public Rigidbody2D rb;
    public Camera cam;

    public Vector2 moveDirection;
    public Vector2 mousePos;

    public PlayerStats playerStats;

    private void Start()
    {
        GameObject thePlayer = GameObject.Find("PlayerObj");
        PlayerStats playerStats = thePlayer.GetComponent<PlayerStats>();
        moveSpeed = playerStats.pMoveSpeed;
    }

    void Update()
    {
        ProcessInputs();
        SetCameraPosition();
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
        rb.rotation = angle;
    }

    void SetCameraPosition()
    {
        cam.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -100f);
    }
}
