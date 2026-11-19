using System;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreSystem : MonoBehaviour
{
    public float score;
    public float value;
    public float multiplier;
    public float valuePrice;
    public float multiplierPrice;
        
    
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text valueText;
    [SerializeField] TMP_Text multiplierText;

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

    public void ValueUp()
    {
        if (score >= valuePrice)
        {
            value++;
            score -= valuePrice;
            valuePrice *= 2f;
            valueText.SetText("Plink Jr. Up: " + valuePrice);

        }
    }
    public void MultiUp()
    {
        if (score >= multiplierPrice)
        {
            multiplier++;
            score -= multiplierPrice;
            multiplierPrice *= 2f;
            multiplierText.SetText("Mr. Plink Up: " + multiplierPrice);

        }
    }
}
