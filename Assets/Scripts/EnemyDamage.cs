using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 1;
    public float damageCooldown = 1f;

    private float nextDamageTime;

    private void OnEnable()
    {
        nextDamageTime = 0f;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Time.time >= nextDamageTime)
            {
                PlayerHealth playerHealth =
                    collision.gameObject.GetComponent<PlayerHealth>();

                if (playerHealth != null)
                {
                    nextDamageTime = Time.time + damageCooldown;
                    playerHealth.TakeDamage(damage);
                }
            }
        }
    }
}