using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;
    [SerializeField] int scoreP1;
    [SerializeField] int scoreP2;

    public static ScoreManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreManager>();
                if (instance == null)
                {
                    GameObject go = new GameObject("ScoreManager");
                    instance = go.AddComponent<ScoreManager>();
                }
            }
            return instance;
        }

    }

    public int ScoreP1
    {
        get { return scoreP1; }
        set { scoreP1 = value; }
    }

    public int ScoreP2
    {
        get { return scoreP2; }
        set { scoreP2 = value; }
    }
}
