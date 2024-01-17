using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Elliott

public class ArmController : MonoBehaviour
{
    public Movementscript playerMovementScript;
    public float maxRotation = 80f;

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


    }
}