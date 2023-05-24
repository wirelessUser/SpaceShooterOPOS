using UnityEngine;

public class EnemyService
{
    private EnemyPool enemyPool;
    
    private bool isSpawning;
    private float spawnRate;

    public EnemyService(EnemyView enemyPrefab, EnemyScriptableObject enemySO)
    {
        enemyPool = new EnemyPool(enemyPrefab, enemySO);
    }

    public void ToggleEnemySpawning(bool setActive) => isSpawning = setActive;

    private async void SpawnEnemy()
    {
        // TODO: If spawning is active then,
        // Get a random orientation for the enemy (Up/Down/Left/Right)
        // Calculate spawn position outside the game screen, according to the orientation.
        // Use SpawnEnemyAtPosition() method to spawn the enemy at the spawn position.
    }

    private async void IncreaseDifficulty()
    {
        // TODO: Decrease Spawn Rate over time (if spawning is active) .
    }

    private void SpawnEnemyAtPosition(Vector3 spawnPosition)
    {
        EnemyController spawnedEnemy = enemyPool.GetEnemy();
        spawnedEnemy.SetPosition(spawnPosition);
    }

    public void ReturnEnemyToPool(EnemyController enemyToReturn) => enemyPool.ReturnItem(enemyToReturn);
}

public enum EnemyOrientation
{
    Up,
    Down,
    Left,
    Right
}