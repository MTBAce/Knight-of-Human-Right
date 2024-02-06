using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Elliott

public class ArmController : MonoBehaviour
{
    public Movementscript playerMovementScript;
    public float maxRotation = 80f;

    public GameObject player;
    public playerHealth playerHealth;

    public float swordBlockDelay = 2.5f;
    public float timeSinceLastBlock = 0.0f;

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
        mousePosition.z = armPosition.z; 

        Vector3 difference = mousePosition - armPosition;
        difference.Normalize();

        float rotationZ = Mathf.Atan2(-difference.y, difference.x) * Mathf.Rad2Deg;

        if (playerMovementScript.isFacingRight)
        {
            transform.rotation = Quaternion.Euler(180f, 0f, rotationZ);
        }
        else
        {
            
            rotationZ = Mathf.Atan2(-difference.y, -difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(180f, 180f, rotationZ); 
          
        }

        if (!playerHealth.isPlayerAlive)
        {
            Destroy(gameObject);
        }

        timeSinceLastBlock += Time.deltaTime; //The time since the last sword block

        if (Input.GetKey(KeyCode.Mouse1) && timeSinceLastBlock >= swordBlockDelay) //Use Sword
        {
            isUsingSword = true;
            isUsingCrossbow = false;
            UsingSword();

            timeSinceLastBlock = 0.0f;
        }
        else
        {
            isUsingCrossbow = true;
            isUsingSword = false;
            UsingCrossbow();
        }
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