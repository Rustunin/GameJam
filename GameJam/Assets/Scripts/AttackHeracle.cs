using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHeracle : MonoBehaviour
{
    public GameObject fireBall;
    public Transform fireballpos1;
    public Transform fireballpos2;
    public Transform fireballpos3;
    float DistanceHeracle=7f;
    float cooldown1;
    float cooldown2;
    float cooldown3;
    public GameObject Target;
    public Vector3 offset;
    Vector3 dir1;
    Vector3 dir2;
    Vector3 dir3;
    public static bool OnRange;

    private void Start()
    {          
        cooldown1 = 0f;
        cooldown2 = 0f;
        cooldown3 = 0f;
        OnRange = false;
    }

    private void Update()
    {      
        cooldown1 -= Time.deltaTime;
        cooldown2 -= Time.deltaTime;
        cooldown3 -= Time.deltaTime;
        if (cooldown1 <= 0)
        {
            firstHead();
        }
        if (cooldown2 <= 0)
        {
            secondHead();
        }
        if (cooldown3 <= 0)
        {
            thirdHead();
        }
    }

    void firstHead()
    {
        
            if (Vector3.Distance(transform.position, Target.transform.position) < DistanceHeracle)
            {
                dir1 = (Target.transform.position + offset) - fireballpos1.transform.position;
                GameObject GO1 = Instantiate(fireBall, fireballpos1.position, Quaternion.identity);
                GO1.GetComponent<Rigidbody>().velocity = dir1.normalized * 2000 * Time.deltaTime;
                cooldown1 = Random.Range(0.3f, 2);
            }
        
    }
    void secondHead()
    {

        if (Vector3.Distance(transform.position, Target.transform.position) < DistanceHeracle)
        {           
            dir2 = (Target.transform.position + offset) - fireballpos1.transform.position;
            GameObject GO2 = Instantiate(fireBall, fireballpos2.position, Quaternion.identity);
            GO2.GetComponent<Rigidbody>().velocity = dir2.normalized * 2000 * Time.deltaTime;
            cooldown2 = Random.Range(0.3f, 2);
        }

    }
    void thirdHead()
    {

        if (Vector3.Distance(transform.position, Target.transform.position) < DistanceHeracle)
        {          
            dir3 = (Target.transform.position + offset) - fireballpos1.transform.position;
            GameObject GO3 = Instantiate(fireBall, fireballpos3.position, Quaternion.identity);
            GO3.GetComponent<Rigidbody>().velocity = dir3.normalized * 2000 * Time.deltaTime;            
            cooldown3 = Random.Range(0.3f, 2);
        }
        
    }

}
