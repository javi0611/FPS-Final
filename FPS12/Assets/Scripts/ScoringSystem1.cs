using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem1 : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    void Start()
    {
        
        
    }
    void Update()
    {
      
        scoreText.text = "Score: " + score;
    }

    public static void AddScore()
    {
        
        score += 50;
    }
}
