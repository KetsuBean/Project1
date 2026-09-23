using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3;

    private int currentHealth;

    private void OnEnable()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
{
    currentHealth -= damage;

    Debug.Log($"{gameObject.name} hit for {damage} damage. Health: {currentHealth}/{maxHealth}");

    if (currentHealth <= 0)
    {
        Debug.Log($"{gameObject.name} defeated!");
        gameObject.SetActive(false);
    }
}
}