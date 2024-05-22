using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float spawnInterval = 2f;
    public float spawnRadius = 10f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRadius, spawnRadius), transform.position.y, 0f);
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
