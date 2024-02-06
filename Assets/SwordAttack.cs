using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public GameObject player;
    public ArmController armController;

    public bool isUsingSword;
    public int swordDamage = 3;

    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        isUsingSword = player.GetComponent<ArmController>();
        EnemyHealth enemy = gameObject.GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && isUsingSword == true && collision.gameObject.tag == "Enemy")
        {
           
            if (enemy != null)
            {
                enemy.TakeDamage(swordDamage);
                Debug.Log("Enemy hit");
            }
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Touching Enemy");
       
    }

}
