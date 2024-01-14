using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour
{

    public Movementscript playerMovementScript;

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 armPosition = transform.position;
        mousePosition.z = armPosition.z; // Ensure the z-axis is consistent

        Vector3 difference = mousePosition - armPosition;
        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (playerMovementScript.isFacingRight)
        {
            
            rotationZ = Mathf.Atan2(difference.y, -difference.x) * Mathf.Rad2Deg;
        }

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
    }
}