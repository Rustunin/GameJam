using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TRIGGERTONEWMIR : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (transform.tag == "Cave")
        {
            PlayerControll.playerSpeed = 3f;
            PlayerControll.jumpHeight = 1.25f;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                PlayerControll.playerSpeed *= 2;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                PlayerControll.playerSpeed = 3f;
            }
            SceneManager.LoadScene("Cave");
        }
        if (transform.tag=="wayToDragon")
        {
            AttackHeracle.OnRange = true;
        }     
    }
    private void OnTriggerExit(Collider other)
    {
        if (transform.tag=="wayToDragon")
        {
            AttackHeracle.OnRange = false;
        }
    }
}
