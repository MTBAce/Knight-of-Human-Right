using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

//Elliott

public class Arrow : MonoBehaviour
{
    public float life = 40.0f;
    public GameObject bulletPrefab;

    private bool hasCollided = false;
    private Collider2D col;
    private RigidbodyConstraints2D constraints;

    Rigidbody2D rb;

    // Change to prefered damage amount.


    public int damage = 10;

    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       col = GetComponent<Collider2D>();
        
    }

    void Awake()
    {
        Destroy(gameObject, life);
    }

   

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            
            // Get the Enemy script attached to the collided object and call TakeDamage
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
       

        if(!hasCollided && collision.gameObject.tag != "Player" )
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;

            hasCollided = true;

            col.enabled = false;
            
        }
    
    }
}
