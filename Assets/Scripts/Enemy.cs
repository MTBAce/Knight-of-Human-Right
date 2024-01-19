using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Alexis

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
    Rigidbody2D rb;
    Collider2D col;

    public bool isEnemyAlive = true;

    Animator animator;

    private bool hasCollided = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public bool IsEnemyAlive()
    {
        return isEnemyAlive;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health == 0)
        {
            Die();
        }
    }

    void Die()
    {

        isEnemyAlive = false;
        animator.SetTrigger("death");
        StartCoroutine(DieCoroutine());
 
    }

    IEnumerator DieCoroutine()
    {
        yield return new WaitForSeconds(1f);

        Destroy(gameObject);
    }

}