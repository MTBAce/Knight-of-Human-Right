using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//Alexis, Elliott

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
    Rigidbody2D rb;
    Collider2D col;

    public GameObject deathParticle;

    public bool isEnemyAlive = true;

    Animator animator;

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

        Instantiate(deathParticle, gameObject.transform.position, gameObject.transform.rotation);
        if (health <= 0)
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