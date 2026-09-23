using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private int coins;

    private void Awake()
    {
        coins = 0;
        Debug.Log($"Starting coins: {coins}");
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        Debug.Log($"Earned {amount} coins. Total coins: {coins}");
    }

    public bool TrySpendCoins(int amount)
    {
        if (coins < amount)
        {
            Debug.Log("Not enough coins!");
            return false;
        }

        coins -= amount;
        Debug.Log($"Spent {amount} coins. Remaining coins: {coins}");
        return true;
    }
}