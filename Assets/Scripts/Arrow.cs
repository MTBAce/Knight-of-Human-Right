using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float life = 3;
    public GameObject bulletPrefab;

    private bool hasCollided = false;
    private Collider2D col;

    Rigidbody2D rb;


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


        if(!hasCollided && collision.gameObject.tag != "Player" )
        {
            transform.parent = collision.transform;

            col.enabled = false;

            rb.isKinematic = true;

            hasCollided = true;
        }
    }
}
