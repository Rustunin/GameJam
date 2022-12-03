using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TRIGGERTONEWMIR : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (transform.tag == "pechera")
        {
            PlayerControll.changePos = true;
            Debug.Log("da");
        }
    }
}
