using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour, IUpdate
{
    private Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void NewUpdate()
    {
        var playerPos = playerTransform.position;
        if (playerTransform != null)
        {
            transform.LookAt(playerPos);
            transform.Translate(0, 0, 0.05f);
        }
    }
}