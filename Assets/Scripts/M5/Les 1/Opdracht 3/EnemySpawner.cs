using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;   // sleep je enemy prefab hier naartoe in de inspector
    public List<GameObject> enemies = new List<GameObject>();

    public float spawnInterval = 1f; // elke seconde spawnen
    private float timer = 0f;

    void Update()
    {
        // Toets W: spawn in 1 keer 100 enemies
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                SpawnEnemy();
            }
        }

        // Toets Q: verwijder alle enemies
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearEnemies();
        }

        // Elke seconde 3 enemies spawnen
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            for (int i = 0; i < 3; i++)
            {
                SpawnEnemy();
            }
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab, transform.position, transform.rotation);
        enemies.Add(enemy);
    }

    void ClearEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();
    }
}
