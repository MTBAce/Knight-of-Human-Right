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

    public float jumpDelay = 1.0f;
    public float timeSinceLastJump = 0.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(0, 0);
    }


    private void Update()
    {
        timeSinceLastJump += Time.deltaTime;
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

        if (Input.GetKey(KeyCode.Space) && isGrounded && timeSinceLastJump >= jumpDelay || Input.GetKey(KeyCode.W) && isGrounded && timeSinceLastJump >= jumpDelay) 
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;

            timeSinceLastJump = 0.0f;
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