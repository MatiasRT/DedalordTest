using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] string input;
    [SerializeField] float speed = 0;
    [SerializeField] float startX;

    //[SerializeField] TopCollisionController tccScript;
    //[SerializeField] DetectCollision[] dtScript;

    float animMove;

    private Rigidbody2D player;
    private Animator anim;

    void Start()
    {
        //tccScript.restart.AddListener(ReturnToOGPosition);
        /*for(int i=0; i < dtScript.Length; i++)
        {
            dtScript[i].coll.AddListener(ReturnToOGPosition);
        }*/
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    { 
        player.velocity = new Vector2(0, Mathf.Lerp(0, Input.GetAxis(input) * speed, 1f));
    }

    void Update()
    {
        animMove = Input.GetAxis(input) * speed;

        anim.SetFloat("move", Mathf.Abs(animMove));
    }

    /*void ReturnToOGPosition()
    {
        player.position = new Vector2(startX, -4.3f);
    }*/
}