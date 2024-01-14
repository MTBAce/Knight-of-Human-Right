using UnityEngine;

public class CrossbowAim : MonoBehaviour
{
    public GameObject character; // Reference to the character GameObject

    void Update()
    {
        AimTowardsMouse();
    }

    private void AimTowardsMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 difference = mousePosition - transform.position;
        difference.Normalize();

        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);

        // Check if the mouse is to the left of the character
        if (mousePosition.x < character.transform.position.x)
        {
            // Flip the crossbow along the X-axis
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            // Ensure the crossbow is not flipped along the X-axis
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}