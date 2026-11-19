using System;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public float score;
    public float value;
    public float multiplier;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "1x")
        {
            score += value *  multiplier * 1;
        }

        if (other.tag == "1.5x")
        {
            score += value *  multiplier * 1.5f;
        }
        
        if (other.tag == "2x")
        {
            score += value *  multiplier * 2f;
        }
    }
}
