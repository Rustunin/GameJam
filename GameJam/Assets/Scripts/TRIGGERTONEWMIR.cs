using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TRIGGERTONEWMIR : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Cave");
        PlayerControll.playerSpeed = 2f;
        PlayerControll.jumpHeight = 2f;
    }
}
