using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class attackEnemy : MonoBehaviour
{
    //distance count
    public static float DistancefromTarget;
    public float ToTarget;
    //3D objects
    public GameObject Target;
    public GameObject E;
    public GameObject Chest;
    //conditions
    private int isActive = 0;
    private bool isOpen = false;
    int counter = 0;
    public static int animWalkcount;
    //UI
    public GameObject SwordPNG;
    public GameObject Sword3d;
    public GameObject TextTakeSword;
    
    private void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToTarget = Hit.distance;
            DistancefromTarget = ToTarget;
        }
        if (attackEnemy.animWalkcount == 0)
        {
            SwordPNG.SetActive(false);
        }
        else if (attackEnemy.animWalkcount == 1)
        {
            SwordPNG.SetActive(true);
            isActive = 1;
        }

        if (animWalkcount==1)
        {
            TextTakeSword.SetActive(false);
            if (isActive==1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    SwordPNG.GetComponent<Animation>().Play("sword1");
                }
              
            }
            
        }

       
        
        if (counter == 0)
        {
            if (DistancefromTarget <= 8)
            {
                if (Hit.collider.tag == "chestOpen")
                {
                    E.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        Chest.GetComponent<Animation>().Play("openningChest");
                        counter += 1;
                       
                    }
                }
                else
                {
                    E.SetActive(false);
                }
            }
        }
        if (animWalkcount <1)
        {
            if (counter > 0)
            {
                if (DistancefromTarget <= 8)
                {
                    if (isOpen)
                    {
                        E.SetActive(false);
                        TextTakeSword.SetActive(true);
                        if (Input.GetKeyDown(KeyCode.E))
                        {
                            animWalkcount = 1;
                            TakeSword();
                        }
                    }

                }
                else
                {
                    TextTakeSword.SetActive(false);
                }
                isOpen = true;
            }
        }       
    }

    private void TakeSword()
    {
        Sword3d.SetActive(false);
        SwordPNG.SetActive(true);
    }
}
