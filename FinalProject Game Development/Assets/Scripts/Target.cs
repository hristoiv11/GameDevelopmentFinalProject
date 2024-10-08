using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public int health = 3;  // Example health value

    // Method to handle damage
    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        Debug.Log("Health remaining: " + health);

        if (health <= 0)
        {
            ScoreSC.Instance.AddScore(1);
            Destroy(gameObject); // Destroy the target if health is 0 or less
        }
    }

  
}
