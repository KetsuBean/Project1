using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public SimplePool pool;
    public Transform player;
    public PlayerInventory playerInventory;
    public RunScore runScore;
    public Transform[] spawnPoints;

    public float spawnInterval = 2f;

    private float nextSpawnTime;

    private void Update()
    {
        if (!player.gameObject.activeInHierarchy)
        {
            return;
        }

        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    private void SpawnEnemy()
    {
        GameObject enemy = pool.GetFromPool();

        if (enemy != null)
        {
            int index = Random.Range(0, spawnPoints.Length);

            Rigidbody2D body = enemy.GetComponent<Rigidbody2D>();
            body.position = spawnPoints[index].position;
            body.linearVelocity = Vector2.zero;
            body.angularVelocity = 0f;

            EnemyMovement movement = enemy.GetComponent<EnemyMovement>();
            movement.player = player;

            EnemyHealth health = enemy.GetComponent<EnemyHealth>();
            health.playerInventory = playerInventory;
            health.runScore = runScore;
        }
    }
}