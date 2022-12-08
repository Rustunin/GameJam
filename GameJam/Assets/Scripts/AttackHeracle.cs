using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHeracle : MonoBehaviour
{
    public GameObject fireBall;
    public Transform fireballpos1;
    public Transform fireballpos2;
    public Transform fireballpos3;
    float DistanceHeracle=15f;
    float cooldown;
    public GameObject Target;
    public Vector3 offset;
    Vector3 dir1;
    Vector3 dir2;
    Vector3 dir3;
    public static bool OnRange;

    private void Start()
    {          
        cooldown = 0f;
    }

    private void Update()
    {
        if (OnRange)
        {
            cooldown -= Time.deltaTime;
            if (cooldown <= 0)
            {
                if (Vector3.Distance(transform.position, Target.transform.position) < DistanceHeracle)
                {
                    dir1 = (Target.transform.position + offset) - fireballpos1.transform.position;
                    dir2 = (Target.transform.position + offset) - fireballpos1.transform.position;
                    dir3 = (Target.transform.position + offset) - fireballpos1.transform.position;
                    AttackChamp();
                    cooldown = 2.5f;
                }
            }
        }
       
    }

    void AttackChamp()
    {
        GameObject GO1 = Instantiate(fireBall, fireballpos1.position, Quaternion.identity);
        GameObject GO2 = Instantiate(fireBall, fireballpos2.position, Quaternion.identity);
        GameObject GO3 = Instantiate(fireBall, fireballpos3.position, Quaternion.identity);
        GO1.GetComponent<Rigidbody>().velocity = dir1.normalized * 1200 * Time.deltaTime;
        GO2.GetComponent<Rigidbody>().velocity = dir2.normalized * 1200 * Time.deltaTime;
        GO3.GetComponent<Rigidbody>().velocity = dir3.normalized * 1200 * Time.deltaTime;
    }
}
