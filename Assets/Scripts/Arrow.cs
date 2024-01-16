using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public GameObject bulletPrefab;

    Rigidbody2D rb;

    public float bulletDamage;

    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter(Collision collision)
    {

<<<<<<< Updated upstream

        if(!hasCollided && collision.gameObject.tag != "Player" )
        {
            transform.parent = collision.transform;

            col.enabled = false;

            rb.isKinematic = true;

            hasCollided = true;
=======
        Debug.Log("Hit");
        GameObject otherGameObject = collision.gameObject;
        enemyScript hitEnemy = otherGameObject.GetComponent<enemyScript>();

        if (hitEnemy != null)
        {
            Debug.Log("Enemy Hit");
            hitEnemy.TakeDamage();
            Destroy(gameObject);
>>>>>>> Stashed changes
        }
    }


}
