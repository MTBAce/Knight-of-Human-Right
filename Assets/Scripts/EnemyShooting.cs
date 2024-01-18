using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Alexis och Elliott

public class EnemyShooting : MonoBehaviour
{

    public GameObject EnemyArrow;
    public Transform FirePoint;
    private GameObject player;

    public playerHealth playerHealth;
    public EnemyHealth enemyHealth;




    private bool isFacingRight = false;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<playerHealth>();
        enemyHealth = enemyHealth.GetComponent<EnemyHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        if(distance < 14 && playerHealth.isPlayerAlive && enemyHealth.isEnemyAlive == true)
        {
            timer += Time.deltaTime;

            if (timer > 1.8)
            {
                timer = 0;
                shoot();
            }
        }

        if((player.transform.position.x > transform.position.x && !isFacingRight) || (player.transform.position.x < transform.position.x && isFacingRight))
        {
            Flip();
        }
                
    
    }
        
    void shoot()
    {
        Instantiate(EnemyArrow, FirePoint.position, Quaternion.identity);
    }

    void Flip()
    {
        isFacingRight= !isFacingRight;
        transform.Rotate(0, 180, 0);

    }

}
