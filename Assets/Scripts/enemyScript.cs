using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    int health = 3;

    public void TakeDamage()
    {
        health -= 1;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    

}
