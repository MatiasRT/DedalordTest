﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionP1 : MonoBehaviour
{
    [SerializeField] float startX;
    [SerializeField] float startY; //-4.3
    [SerializeField] DetectCollision[] dtScript;
    [SerializeField] TopCollisionController tccScript;

    private Rigidbody2D playerP1;

    void Start()
    {
        playerP1 = GetComponent<Rigidbody2D>();
        tccScript.restart.AddListener(ReturnToP1Position);
        for (int i = 0; i < dtScript.Length; i++)
        {
            dtScript[i].collP1.AddListener(ReturnToP1Position);
        }
    }

    void ReturnToP1Position()
    {
        playerP1.position = new Vector2(startX, startY);
    }
}