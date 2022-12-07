using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHeracle : MonoBehaviour
{
    public GameObject Heracle;
    public GameObject fireBall;
    public Transform fireballpos1;
    public Transform fireballpos2;
    public Transform fireballpos3;
    float DistanceHeracle=10f;
    float cooldown;
    float forcespeed = -10f;

    private void Start()
    {          
        cooldown = 0f;
    }

    private void Update()
    {
      
        if (cooldown <= 0)
        {
            if (Vector3.Distance(transform.position, Heracle.transform.position) < DistanceHeracle)
            {

                AttackChamp();
                cooldown = 2.5f;
            }         
        }
        cooldown -= Time.deltaTime;
    }

    void AttackChamp()
    {
        GameObject GO1 = Instantiate(fireBall, fireballpos1.position, Quaternion.identity);
        GameObject GO2 = Instantiate(fireBall, fireballpos2.position, Quaternion.identity);
        GameObject GO3 = Instantiate(fireBall, fireballpos3.position, Quaternion.identity);
        GO1.GetComponent<Rigidbody>().AddForce(transform.forward * 700*Time.deltaTime, ForceMode.Impulse);
        GO2.GetComponent<Rigidbody>().AddForce(transform.forward * 700*Time.deltaTime, ForceMode.Impulse);
        GO3.GetComponent<Rigidbody>().AddForce(transform.forward * 700*Time.deltaTime, ForceMode.Impulse);
    }
}
