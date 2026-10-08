using UnityEngine;
using TMPro;

public class RunScore : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private int enemiesDefeated;
    private int highScore;

    private void Awake()
    {
        enemiesDefeated = 0;
        highScore = PlayerPrefs.GetInt("KillHighScore", 0);
        UpdateScoreText();
    }

    public void AddKill()
    {
        enemiesDefeated++;

        if (enemiesDefeated > highScore)
        {
            highScore = enemiesDefeated;

            PlayerPrefs.SetInt("KillHighScore", highScore);
            PlayerPrefs.Save();
        }

        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + enemiesDefeated;
        highScoreText.text = "High Score: " + highScore;
    }
}