using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWatching : MonoBehaviour
{
    public GameObject player;
    public Vector3 dir;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        Vector3 targetPos = player.transform.position;

        dir = targetPos - (Vector3)transform.position;

        transform.forward = dir;
    }
}
