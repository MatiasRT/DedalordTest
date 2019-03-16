using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TopCollisionController : MonoBehaviour
{
    [HideInInspector] [SerializeField] UnityEvent restart;
    [HideInInspector] [SerializeField] UnityEvent addPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        restart.Invoke();
        addPoints.Invoke();
    }

    public UnityEvent Restart
    {
        get { return restart; }
    }

    public UnityEvent AddPoints
    {
        get { return addPoints; }
    }
}