using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Alexis

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
    Rigidbody2D rb;
    Collider2D col;

    private bool hasCollided = false;

    // Method to call when the enemy gets hit
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Implement death logic here
        Destroy(gameObject);
    }

   
}