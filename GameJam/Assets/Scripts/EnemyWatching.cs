using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWatching : MonoBehaviour
{
    public GameObject player;
    public Vector3 dir;
    public static Vector3 dirr;

    void Update()
    {
        if (player==null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 targetPos = player.transform.position;

        dir = targetPos - (Vector3)transform.position;

        transform.forward = dir;
        dirr = transform.forward;

        
    }
}
