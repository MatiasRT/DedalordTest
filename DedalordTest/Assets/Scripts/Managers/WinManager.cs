using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class WinManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject winP1;
    [SerializeField] GameObject winP2;

    [HideInInspector] [SerializeField] UnityEvent winGame;

    void Update()
    {
        if(ScoreManager.Instance.ScoreP1 == 10)
        {
            panel.SetActive(true);
            winP1.SetActive(true);
            Win();
        }

        if (ScoreManager.Instance.ScoreP2 == 10)
        {
            panel.SetActive(true);
            winP2.SetActive(true);
            Win();
        }
    }

    public void Win()
    {
        winGame.Invoke();
        if (Input.GetKeyDown(KeyCode.Space))
            StartCoroutine(ChangeToMenu());
    }

    IEnumerator ChangeToMenu()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Menu");
    }

    public UnityEvent WinGame
    {
        get { return winGame; }
    }
}