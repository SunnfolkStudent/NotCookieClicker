using System;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public float score;
    public float value;
    public float multiplier;
    
    [SerializeField] TMP_Text scoreText;

    public void AddScore1x()
    {
            score += value *  multiplier * 1f;
            scoreText.SetText("Score: " + score);
    }

    public void AddScore2x()
    {
        score += value *  multiplier * 2f;
        scoreText.SetText("Score: " + score);   
    }

    public void AddScore3x()
    {
        score += value *  multiplier * 3f;
        scoreText.SetText("Score: " + score);  
    }

    public void AddScore4x()
    {
        score += value *  multiplier * 4f;
        scoreText.SetText("Score: " + score);  
    }
}
