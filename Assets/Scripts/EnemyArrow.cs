using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Alexis och Elliott

public class EnemyArrow : MonoBehaviour
{
    public GameObject player;
    public GameObject playerSword;
    private Rigidbody2D rb;
    public float force;
    private float timer;

    private bool hasCollided = false;

    private Collider2D col;

    public int damage = 10;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerSword = GameObject.FindGameObjectWithTag("Sword");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);   
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Player")
        {
            playerHealth player = collision.gameObject.GetComponent<playerHealth>();
            if (player != null)
            {
                player.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
        if (collision.collider.gameObject.tag == "Sword")
        {
            Debug.Log("Blocked");
        }
        
        
        
        
        if (!hasCollided && collision.gameObject.tag != "Player" && collision.gameObject.tag !="Enemy" && collision.gameObject.tag != "PlayerArrow")
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;

            hasCollided = true;

            col.enabled = false;

        }
    }


}
