using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Elliott
public class cameraFollow : MonoBehaviour
{

    public Vector3 offset = new Vector3 (0, 4, -10f);
    public float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;

    // To fix bug when player dies
    private bool isTargetAlive = true;

    [SerializeField] public Transform Target;

   

    // Update is called once per frame
    void Update()
    {
        if (Target == null)
        {
            isTargetAlive = false;
        }
        
        if (!isTargetAlive)
        {
            return;
        }

        Vector3 targetPosition = Target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
