using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int coinReward = 1;
    public PlayerInventory playerInventory;
    public RunScore runScore;

    private int currentHealth;

    private void OnEnable()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0)
        {
            return;
        }

        currentHealth -= damage;

        Debug.Log($"{gameObject.name} hit for {damage} damage. Health: {currentHealth}/{maxHealth}");

        if (currentHealth <= 0)
        {
            Debug.Log($"{gameObject.name} defeated!");

            runScore.AddKill();
            playerInventory.AddCoins(coinReward);
            gameObject.SetActive(false);
        }
    }
}