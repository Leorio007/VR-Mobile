using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;






public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public int score = 0;
    public Text scoreText;

    void Awake()
    {
        
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
        UpdateScoreText();
    }

    public void AddPoints(int points)
    {
        
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        
        scoreText.text = "Score: " + score.ToString();
    }
}
