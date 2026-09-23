using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;

    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        Debug.Log($"Player hit for {damage} damage. Health: {currentHealth}/{maxHealth}");

        if (currentHealth <= 0)
        {
            Debug.Log("Player defeated!");
            gameObject.SetActive(false);
        }
    }
}