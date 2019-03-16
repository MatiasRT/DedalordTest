using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] int scoreToAdd = 0;
    [SerializeField] int player;

    [SerializeField] TopCollisionController tccScript;

    Text scoreText;
    private int score;

    void Start()
    {
        scoreText = GetComponent<Text>();
        tccScript.AddPoints.AddListener(AddScore);    
    }

    void AddScore()
    {
        score += scoreToAdd;
        scoreText.text = score + "";
        switch (player)
        {
            case 1:
                ScoreManager.Instance.ScoreP1 += scoreToAdd;
                break;
            case 2:
                ScoreManager.Instance.ScoreP2 += scoreToAdd;
                break;
        }
    }
}