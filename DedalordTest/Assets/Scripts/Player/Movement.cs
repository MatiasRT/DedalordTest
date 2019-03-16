using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] string input;
    [SerializeField] float speed = 0;
    [SerializeField] WinManager wmScript;

    float animMove;

    private Rigidbody2D player;
    private Animator anim;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        wmScript.WinGame.AddListener(Stop);
    }

    void FixedUpdate()
    {
        player.velocity = new Vector2(0, Mathf.Lerp(0, Input.GetAxis(input) * speed * Time.deltaTime, 1f));
    }

    void Update()
    {
        animMove = Input.GetAxis(input) * speed;

        anim.SetFloat("move", Mathf.Abs(animMove));
    }

    void Stop()
    {
        speed = 0;
    }
}