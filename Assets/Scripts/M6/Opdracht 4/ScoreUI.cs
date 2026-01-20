using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        ScoreManager.instance.OnScoreChanged += UpdateScore;
        UpdateScore(0);
    }

    void UpdateScore(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}