using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Elliott
public class playerHealth : MonoBehaviour
{
    public Animator animator;

    public bool isPlayerAlive = true;
    public GameObject Deathscreen;

    public int health = 5;
    // Start is called before the first frame update 

    public bool IsPlayerAlive()
    {
        return isPlayerAlive;
    }
    
    private void Start()
    {
        Time.timeScale = 1f;
        animator = GetComponent<Animator>();
      
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health<=0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player died");

        isPlayerAlive = false;
        animator.SetTrigger("death");
        Deathscreen.SetActive(true);
        StartCoroutine(DieCoroutine());

    }

    IEnumerator DieCoroutine()
    {
        yield return new WaitForSeconds(1.1f);

        Time.timeScale = 0f;
    }


}
