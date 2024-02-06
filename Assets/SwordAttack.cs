using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public GameObject player;
    public ArmController armController;

    public EnemyHealth enemyHealth;
    public bool isTouchingEnemy;

    public int damage = 10;

    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemyHealth = enemy.GetComponent<EnemyHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (isTouchingEnemy == true)
            {
                Debug.Log("Attacked Enemy");
                enemyHealth.TakeDamage(damage);
                Debug.Log("Enemy hit");
            }
            else
            {
                Debug.Log("Sword attack");
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isTouchingEnemy = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isTouchingEnemy = false;
        }
    }

}
