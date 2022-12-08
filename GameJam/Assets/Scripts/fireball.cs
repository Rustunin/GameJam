using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    float timeToDestroy = 2f;
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.collider.tag=="Heracl")
        {
            HealthBar.heatltake = true;
        }
        Destroy(gameObject);
    }
}
