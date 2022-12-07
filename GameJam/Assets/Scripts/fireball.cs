using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    Rigidbody rb;
    GameObject Target;
    float forcespeed=-10f;
    float timeToDestroy = 2f;
    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Heracl");
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Target.transform.position*forcespeed*Time.deltaTime,ForceMode.Impulse);
    }

    private void Update()
    {
        Destroy(gameObject,timeToDestroy);
    }
}
