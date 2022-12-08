using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class attackEnemy : MonoBehaviour
{
    public static float DistancefromTarget;
    public float ToTarget;
    public GameObject sword;
    public GameObject Target;
    public GameObject E;
    public GameObject Chest;
    private void Update()
    {
        
        RaycastHit Hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Hit))
        {
            ToTarget = Hit.distance;
            DistancefromTarget = ToTarget;
        }
        if (DistancefromTarget<=2)
        {
            if (Hit.collider.tag == "chestOpen")
            {
                E.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Chest.GetComponent<Animation>().Play("openningChest");
                }                             
            }
            else
            {
                E.SetActive(false);
            }
            if (Input.GetMouseButtonDown(0))
            {
                if (Hit.collider.tag=="Ghidorah")
                {
                    Target.SendMessage("ApplyDamage", 20.0);
                    
                }
                
            }
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            sword.GetComponent<Animation>().Play("sword1");
        }
    }
}
