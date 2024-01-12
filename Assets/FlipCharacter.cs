using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour
{
    public bool isFacingRight = true; // Set this according to the initial facing direction of your character

    void Update()
    {
        FlipTowardsMouse();
    }

    private void FlipTowardsMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bool mouseIsLeftOfCharacter = mousePosition.x < transform.position.x;

        // Flip if the mouse is on the opposite side of the character's facing direction
        if (mouseIsLeftOfCharacter != isFacingRight)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
