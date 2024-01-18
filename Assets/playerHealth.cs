using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Elliott
public class playerHealth : MonoBehaviour
{


    public int health = 30;
    // Start is called before the first frame update
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
    }

}
