using UnityEngine;

//Elliott
public class FireArrow : MonoBehaviour
{
    public Transform arrowSpawn;
    public GameObject BulletPrefab;
    public float arrowSpeed = 10;
    public float shootDelay = 1.0f;
    public float timeSinceLastShoot = 0.0f;

    void Update()
    {

        timeSinceLastShoot += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0) && timeSinceLastShoot >= shootDelay)
        {
            var bullet = Instantiate(BulletPrefab, arrowSpawn.position, arrowSpawn.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = arrowSpawn.right * arrowSpeed;

            timeSinceLastShoot = 0.0f;
        }
    }
}