using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TopCollisionController : MonoBehaviour
{
    [HideInInspector] public UnityEvent restart;
    [HideInInspector] public UnityEvent addPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        restart.Invoke();
        addPoints.Invoke();
    }
}