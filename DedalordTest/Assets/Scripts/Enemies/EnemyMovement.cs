using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float startX;
    [SerializeField] float startY;

    [SerializeField] SideCollisionController sccScript;

    private Rigidbody2D enemy;

    void Start()
    {
        sccScript.restartPos.AddListener(ReturnToOGPosition);
        enemy = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        enemy.velocity = new Vector2(Mathf.Lerp(0, speed, 1f) , 0);
    }

    void ReturnToOGPosition()
    {
        enemy.position = new Vector2(startX, startY);
    }
}
