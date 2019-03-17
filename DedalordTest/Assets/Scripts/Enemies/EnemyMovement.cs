using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed = 0;
    [SerializeField] float startX = 0;
    [SerializeField] float startY = 0;

    [SerializeField] SideCollisionController sccScript = null;

    private Rigidbody2D enemy;

    void Start()
    {
        sccScript.RestartPos.AddListener(ReturnToOGPosition);
        enemy = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        enemy.velocity = new Vector2(Mathf.Lerp(0, speed * Time.deltaTime, 1f) , 0);
    }

    void ReturnToOGPosition()
    {
        enemy.position = new Vector2(startX, startY);
    }
}
