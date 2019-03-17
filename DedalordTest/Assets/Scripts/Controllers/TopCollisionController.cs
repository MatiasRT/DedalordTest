using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TopCollisionController : MonoBehaviour
{
    [HideInInspector] [SerializeField] UnityEvent restart = null;
    [HideInInspector] [SerializeField] UnityEvent addPoints = null;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Restart.Invoke();
        AddPoints.Invoke();
        audioSource.Play();
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