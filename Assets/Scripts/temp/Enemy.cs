using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Alexis

public class Enemy : MonoBehaviour
{
    public int health = 100;

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
        // Implement death logic here (like playing an animation, sound, etc.)
        Destroy(gameObject);
    }
}