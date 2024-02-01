using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDeathParticle : MonoBehaviour
{

    private ParticleSystem deathParticle;
    
    // Start is called before the first frame update
    void Start()
    {
        deathParticle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (deathParticle.isPlaying)
        {
            return;
        }

        Destroy(deathParticle);*/
    }
}
