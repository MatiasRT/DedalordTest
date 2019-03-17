using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetectCollision : MonoBehaviour
{ 
    [HideInInspector] [SerializeField] UnityEvent collP1 = null;
    [HideInInspector] [SerializeField] UnityEvent collP2 = null;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
            CollP1.Invoke();
        if (collision.gameObject.CompareTag("Player2"))
            CollP2.Invoke();
        if(!audioSource.isPlaying)
            audioSource.Play();
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