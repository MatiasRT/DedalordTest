using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseController : MonoBehaviour
{
    [HideInInspector] [SerializeField] UnityEvent onPause = null;
    [HideInInspector] [SerializeField] UnityEvent onResume = null;
    [HideInInspector] [SerializeField] UnityEvent onReturn = null;

    public void Resume()
    {
        OnResume.Invoke();
    }

    public void Pause()
    {
        OnPause.Invoke();
    }

    public void LoadMenu()
    {
        OnReturn.Invoke();
    }

    void OnEnable()
    {
        Pause();
    }

    void OnDisable()
    {
        Resume();
    }

    public UnityEvent OnPause
    {
        get { return onPause; }
    }

    public UnityEvent OnResume
    {
        get { return onResume; }
    }

    public UnityEvent OnReturn
    {
        get { return onReturn; }
    }
}

