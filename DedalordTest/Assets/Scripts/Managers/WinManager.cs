using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject winP1;
    [SerializeField] GameObject winP2;

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

    void Win()
    {
        Time.timeScale = 0.0f;
        if (Input.GetKeyDown(KeyCode.Space))        
            StartCoroutine(ChangeToMenu());
    }

    IEnumerator ChangeToMenu()
    {
        yield return new WaitForSeconds(0.2f);
        // CHANGE SCENE
    }
}
