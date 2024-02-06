using UnityEngine;

//Elliott
public class FireArrow : MonoBehaviour
{
    public Transform arrowSpawn;
    public GameObject BulletPrefab;
    public float arrowSpeed = 15;
    public float shootDelay = 0.75f;
    public float timeSinceLastShoot = 0.0f;

    public GameObject player;
    public ArmController armController; 

    public bool isUsingCrossbow;


    public void Start()
    {
        isUsingCrossbow = player.GetComponent<ArmController>(); 
    }
    void Update()
    {

        timeSinceLastShoot += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0) && timeSinceLastShoot >= shootDelay && armController.isUsingCrossbow == true)
        {
            var bullet = Instantiate(BulletPrefab, arrowSpawn.position, arrowSpawn.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = arrowSpawn.right * arrowSpeed;

            timeSinceLastShoot = 0.0f;
        }
    }
}