using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class attack2 : MonoBehaviour
{
    public GameObject SwordPNG;
    float ToTarget;
    public GameObject Target;

    private void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToTarget = Hit.distance;
            attackEnemy.DistancefromTarget = ToTarget;
        }
        if (Input.GetMouseButtonDown(0))
        {
            SwordPNG.GetComponent<Animation>().Play("sword1");
        }
        if (attackEnemy.DistancefromTarget <= 2)
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (Hit.collider.tag == "Ghidorah")
                {
                    Target.SendMessage("ApplyDamage", 20.0);

                }

            }
        }
    }
}
