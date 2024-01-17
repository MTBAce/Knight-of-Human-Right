using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Alexis och Elliott

public class EnemyShooting : MonoBehaviour
{

    public GameObject EnemyArrow;
    public Transform FirePoint;
    private GameObject player;

    private bool isFacingRight;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);
        if(distance < 9)
        {
            timer += Time.deltaTime;

            if (timer > 2)
            {
                timer = 0;
                shoot();
            }
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
