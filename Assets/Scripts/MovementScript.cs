using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Elliott

public class Movementscript : MonoBehaviour
{
    private float horizontal;
    public float jumpingPower = 10;
    public float speed = 0f;
    public bool isFacingRight = true;

    public bool isJumping;

    public Animator animator;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private void Start()
    {
        GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        horizontal = Input.GetAxisRaw("Horizontal"); 
        
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            isJumping = true;

        }

        if(isJumping == true)
        {
            animator.SetBool("isJumping", true);
        }
        else if (isJumping == false)
        {
            animator.SetBool("isJumping", false);
        }
        
        if (mousePos.x < transform.position.x && !isFacingRight)
        {
            Flip();
        }
        else if (mousePos.x > transform.position.x && isFacingRight)
        {
            Flip();
        }

    }
    
    public bool isGrounded()
    {
        isJumping=false;
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        if (horizontal <0 || horizontal >0)
        {
            animator.SetFloat("Speed", Mathf.Abs(horizontal));
        }

        if (horizontal == 0)
        {
            animator.SetFloat("Speed", Mathf.Abs(0));
        }
        



    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;

        transform.Rotate(0, 180, 0);
    }
    
}