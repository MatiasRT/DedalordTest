using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] PauseController pScript;

    [SerializeField] GameObject pCanvas;

    void Start()
    {
        pScript.OnPause.AddListener(PauseGame);
        pScript.OnResume.AddListener(ContinueGame);
        pScript.OnReturn.AddListener(ReturnMenu);
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
            pCanvas.SetActive(!pCanvas.activeSelf);    
    }

    void PauseGame()
    {
        pCanvas.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ContinueGame()
    {
        pCanvas.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    void ReturnMenu()
    {
        pCanvas.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        StartCoroutine(GoToMenu());
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
            PauseGame();
    }

    IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Menu");
    }
}