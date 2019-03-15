using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] string input;
    [SerializeField] float speed = 0;

    private Rigidbody2D player;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    { 
        player.velocity = new Vector2(0, Mathf.Lerp(0, Input.GetAxis(input) * speed, 1f));

        Debug.Log(player.velocity);
    }
}