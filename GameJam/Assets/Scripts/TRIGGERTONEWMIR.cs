using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TRIGGERTONEWMIR : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerControll.playerSpeed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PlayerControll.playerSpeed = 3f;
        }
        SceneManager.LoadScene("Cave");
        PlayerControll.playerSpeed = 3f;
        PlayerControll.jumpHeight = 2f;
    }
}
