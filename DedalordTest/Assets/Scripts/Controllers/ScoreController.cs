using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] int scoreToAdd = 0;

    [SerializeField] TopCollisionController tccScript;

    Text scoreText;
    private int score;

    void Start()
    {
        scoreText = GetComponent<Text>();
        tccScript.addPoints.AddListener(AddScore);    
    }

    void AddScore()
    {
        score += scoreToAdd;
        scoreText.text = score + "";
    }
}