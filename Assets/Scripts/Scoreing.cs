using Unity.VisualScripting;
using UnityEngine;

public class Scoreing : MonoBehaviour
{
    private ScoreSystem scoreController;

    private void Start()
    {
        scoreController = FindAnyObjectByType<ScoreSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("1x"))
        {
            scoreController.AddScore1x();
            Destroy(gameObject);
        }
        
        if (other.CompareTag("2x"))
        {
            scoreController.AddScore2x();
            Destroy(gameObject);
        }
        
        if (other.CompareTag("3x"))
        {
            scoreController.AddScore3x();
            Destroy(gameObject);
        }
        
        if (other.CompareTag("4x"))
        {
            scoreController.AddScore4x();
            Destroy(gameObject);
        }
    }
}
