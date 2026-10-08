using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public TMP_Text healthText;
    public GameOverManager gameOverManager;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
        UpdateHealthText();
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0)
        {
            return;
        }

        currentHealth = Mathf.Max(0, currentHealth - damage);
        UpdateHealthText();

        if (currentHealth <= 0)
        {
            Debug.Log("Player defeated!");
            gameOverManager.GameOver();
            gameObject.SetActive(false);
        }
    }

    private void UpdateHealthText()
    {
        healthText.text = "Health: " + currentHealth + "/" + maxHealth;
    }
}