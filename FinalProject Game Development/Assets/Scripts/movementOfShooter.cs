using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementOfShooter : MonoBehaviour
{
    /*
    public float moveSpeed = 5f;
    public float jumpForce = 700f;
    private bool isGrounded = false;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer; // Added to manage the flipping of the sprite

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
        rb.constraints = RigidbodyConstraints2D.FreezeRotation; // Keep rotation fixed
    }

    void Update()
    {
        Move();
        Jump();
        Flip();
    }

    void Move()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }
    }

    // New method to flip the character sprite
    void Flip()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Flip the sprite by changing its 'flipX' property
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
    }

   */

    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
    }
}
