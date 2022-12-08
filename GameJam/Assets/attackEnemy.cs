using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackEnemy : MonoBehaviour
{
    public GameObject sword;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sword.GetComponent<Animation>().Play("sword1");
        }
    }
}
