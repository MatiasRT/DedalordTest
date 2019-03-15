using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] string input;
    [SerializeField] float speed = 0;
    [SerializeField] float startX;

    private Rigidbody2D player;

    [SerializeField] TopCollisionController tccScript;

    void Start()
    {
        tccScript.restart.AddListener(ReturnToOGPosition);
        player = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    { 
        player.velocity = new Vector2(0, Mathf.Lerp(0, Input.GetAxis(input) * speed, 1f));
    }

    void ReturnToOGPosition()
    {
        player.position = new Vector2(startX, -4.3f);
    }
}