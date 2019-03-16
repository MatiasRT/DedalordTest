using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SideCollisionController : MonoBehaviour
{
    [HideInInspector] [SerializeField] UnityEvent restartPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        restartPos.Invoke();
    }

    public UnityEvent RestartPos
    {
        get { return restartPos; }
    }
}
