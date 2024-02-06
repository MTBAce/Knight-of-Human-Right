using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Elliott med hjälp av Hampus CS 

public class ArmController : MonoBehaviour
{
    public Movementscript playerMovementScript;
    public float maxRotation = 80f;

    public GameObject player;
    public playerHealth playerHealth;

    public bool isUsingSword;
    public bool isUsingCrossbow;

    public GameObject crossbow;
    public GameObject sword;


    private void Start()
    {
        playerHealth = player.GetComponent<playerHealth>();
    }
    void Update()
    {
       
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 armPosition = transform.position;
        mousePosition.z = armPosition.z; // Ensure the z-axis is consistent

        Vector3 difference = mousePosition - armPosition;
        difference.Normalize();

        float rotationZ = Mathf.Atan2(-difference.y, difference.x) * Mathf.Rad2Deg;

        if (playerMovementScript.isFacingRight)
        {
            transform.rotation = Quaternion.Euler(180f, 0f, rotationZ);
        }
        else
        {
            // When facing left, we need to adjust the rotation and potentially flip the arm sprite
            rotationZ = Mathf.Atan2(-difference.y, -difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(180f, 180f, rotationZ); // Flip the arm by rotating around the y-axis
          
        }

        if (!playerHealth.isPlayerAlive)
        {
            Destroy(gameObject);
        }

        if (Input.GetKey(KeyCode.Q)) //Use Sword
        {
            isUsingSword = true;
            isUsingCrossbow = false;
            UsingSword();

        }
        else if (Input.GetKey(KeyCode.E)) //Use Crossbow
        {
            isUsingCrossbow = true;
            isUsingSword = false;
            UsingCrossbow();
        }

        void UsingSword()
        {
            crossbow.SetActive(false);
            sword.SetActive(true);
        }

        void UsingCrossbow()
        {
            crossbow.SetActive(true);
            sword.SetActive(false);
        }
    }
}