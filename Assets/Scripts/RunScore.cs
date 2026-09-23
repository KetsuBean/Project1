using UnityEngine;

public class RunScore : MonoBehaviour
{
    private int enemiesDefeated;
    private int highScore;

    private void Awake()
    {
        enemiesDefeated = 0;
        highScore = PlayerPrefs.GetInt("KillHighScore", 0);

        Debug.Log($"Best kill count: {highScore}");
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

        Debug.Log($"Kills: {enemiesDefeated} | Best: {highScore}");
    }
}