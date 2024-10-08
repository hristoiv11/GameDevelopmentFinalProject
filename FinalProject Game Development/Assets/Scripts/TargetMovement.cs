using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float speed = 2f; // Speed of the target
    public Vector2 direction = Vector2.left; // Direction of the target movement
    public float changeDirectionInterval = 2f; // Time interval to change direction

    private float timeSinceLastChange = 0f;

    void Update()
    {
        // Move the target
        transform.Translate(direction * speed * Time.deltaTime);

        // Change direction at intervals
        timeSinceLastChange += Time.deltaTime;
        if (timeSinceLastChange >= changeDirectionInterval)
        {
            direction = new Vector2(-direction.x, -direction.y); // Reverse direction
            timeSinceLastChange = 0f;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Reverse direction upon collision with player
        if (collision.gameObject.CompareTag("Player"))
        {
            direction = new Vector2(-direction.x, -direction.y);
        }
    }
}
