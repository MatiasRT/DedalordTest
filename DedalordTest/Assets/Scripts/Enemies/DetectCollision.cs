using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetectCollision : MonoBehaviour
{ 
    [HideInInspector] [SerializeField] UnityEvent collP1;
    [HideInInspector] [SerializeField] UnityEvent collP2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
            collP1.Invoke();
        if (collision.gameObject.CompareTag("Player2"))
            collP2.Invoke();
    }

    public UnityEvent CollP1
    {
        get { return collP1; }
    }

    public UnityEvent CollP2
    {
        get { return collP2; }
    }
}