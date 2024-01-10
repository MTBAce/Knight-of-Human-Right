using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movementscript : MonoBehaviour
{
    public float speed = 1f; //Change in inspector
    public float jumpForce = 1f; //Change in inspector
    private Rigidbody2D rb;

    public bool isGrounded;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 0);
    }



    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0);
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded || Input.GetKey(KeyCode.W) && isGrounded)

        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }


    //Checking if the player is touching the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Ground Hit");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Ground Hit");
        }
    }

}