using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Bullet collided with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Target"))
        {
            Target target = collision.gameObject.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(1);
                Destroy(gameObject); // Destroy the bullet
            }
            else
            {
                Debug.LogError("No Target component found on " + collision.gameObject.name);
            }
        }
        else
        {
            // Destroy the bullet upon hitting something other than a target
            Destroy(gameObject);
        }
    }
}

