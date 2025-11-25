using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public TMP_Text scoreText;

    private int score = 0;

    private void OnEnable()
    {
        Pickup.OnPickupCollected += AddScore;
    }

    private void OnDisable()
    {
        Pickup.OnPickupCollected -= AddScore;
    }

    private void Start()
    {
        UpdateScoreText();
    }

    private void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
