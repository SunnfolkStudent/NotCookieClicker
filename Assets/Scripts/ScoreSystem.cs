using System;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public float score;
    public float value;
    public float multiplier;
    
    [SerializeField] TMP_Text scoreText;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "1x")
        {
            score += value *  multiplier * 1f;
            scoreText.SetText("Score: " + score);
        }

        if (other.tag == "2x")
        {
            score += value *  multiplier * 2f;
            scoreText.SetText("Score: " + score);
        }
        
        if (other.tag == "3x")
        {
            score += value *  multiplier * 3f;
            scoreText.SetText("Score: " + score);
        }
        if (other.tag == "4x")
        {
            score += value *  multiplier * 4f;
            scoreText.SetText("Score: " + score);
        }
    }
}
