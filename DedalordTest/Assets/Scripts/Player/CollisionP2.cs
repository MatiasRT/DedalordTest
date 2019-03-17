using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionP2 : MonoBehaviour
{
    [SerializeField] float startX = 0;
    [SerializeField] float startY = 0;
    [SerializeField] DetectCollision[] dtScript = null;
    [SerializeField] TopCollisionController tccScript = null;

    private Rigidbody2D playerP2;

    void Start()
    {
        playerP2 = GetComponent<Rigidbody2D>();
        tccScript.Restart.AddListener(ReturnToP2Position);
        for (int i = 0; i < dtScript.Length; i++)
        {
            dtScript[i].CollP2.AddListener(ReturnToP2Position);
        }
    }

    void ReturnToP2Position()
    {
        playerP2.position = new Vector2(startX, startY);
    }
}
