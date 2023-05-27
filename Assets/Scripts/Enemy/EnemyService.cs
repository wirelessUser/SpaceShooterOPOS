using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CosmicCuration.Enemy
{
    public class EnemyService
    {
        #region Dependencies
        private EnemyScriptableObject enemySO;
        private EnemyPool enemyPool;
        #endregion

        #region Variables
        private bool isSpawning;
        private float currentSpawnRate;
        private float spawnTimer; 
        #endregion

        #region Initialization
        public EnemyService(EnemyView enemyPrefab, EnemyScriptableObject enemySO)
        {
            this.enemySO = enemySO;
            enemyPool = new EnemyPool(enemyPrefab, enemySO.enemyData);
            InitializeVariables();
        }

        private void InitializeVariables()
        {
            isSpawning = true;
            currentSpawnRate = enemySO.initialSpawnRate;
            spawnTimer = currentSpawnRate;
        } 
        #endregion

        public void Update()
        {
            if (isSpawning)
            {
                spawnTimer -= Time.deltaTime;
                if (spawnTimer <= 0)
                {
                    SpawnEnemy();
                    IncreaseDifficulty();
                    ResetSpawnTimer();
                }
            }
        }

        #region Spawning Enemies
        private void SpawnEnemy()
        {
            // Get a random orientation for the enemy (Up / Down / Left / Right)
            EnemyOrientation randomOrientation = (EnemyOrientation)Random.Range(0, Enum.GetValues(typeof(EnemyOrientation)).Length);

            // Calculate a spawn position outside the game screen according to the orientation and spawn an enemy.
            SpawnEnemyAtPosition(CalculateSpawnPosition(randomOrientation), randomOrientation);
        }

        private void SpawnEnemyAtPosition(Vector2 spawnPosition, EnemyOrientation enemyOrientation)
        {
            EnemyController spawnedEnemy = enemyPool.GetEnemy();
            spawnedEnemy.Configure(spawnPosition, enemyOrientation);
        }

        private Vector2 CalculateSpawnPosition(EnemyOrientation enemyOrientation)
        {
            // Calculate a random spawn position outside the visible screen
            Vector3 spawnPosition = Vector3.zero;
            float halfScreenWidth = Camera.main.aspect * Camera.main.orthographicSize;
            float halfScreenHeight = Camera.main.orthographicSize;

            switch (enemyOrientation)
            {
                case EnemyOrientation.Left:
                    spawnPosition.x = halfScreenWidth + enemySO.spawnDistance;
                    spawnPosition.y = Random.Range(-halfScreenHeight, halfScreenHeight);
                    break;

                case EnemyOrientation.Right:
                    spawnPosition.x = -halfScreenWidth - enemySO.spawnDistance;
                    spawnPosition.y = Random.Range(-halfScreenHeight, halfScreenHeight);
                    break;

                case EnemyOrientation.Up:
                    spawnPosition.x = Random.Range(-halfScreenWidth, halfScreenWidth);
                    spawnPosition.y = -halfScreenHeight - enemySO.spawnDistance;
                    break;

                case EnemyOrientation.Down:
                    spawnPosition.x = Random.Range(-halfScreenWidth, halfScreenWidth);
                    spawnPosition.y = halfScreenHeight + enemySO.spawnDistance;
                    break;
            }

            return spawnPosition;
        } 
        #endregion

        private void IncreaseDifficulty()
        {
            if (currentSpawnRate > enemySO.minimumSpawnRate)
                currentSpawnRate -= enemySO.difficultyDelta;
            else
                currentSpawnRate = enemySO.minimumSpawnRate;
        }

        private void ResetSpawnTimer() => spawnTimer = currentSpawnRate;

        public void ToggleEnemySpawning(bool setActive) => isSpawning = setActive;

        public void ReturnEnemyToPool(EnemyController enemyToReturn) => enemyPool.ReturnEnemy(enemyToReturn);
    }

    public enum EnemyOrientation
    {
        Up,
        Down,
        Left,
        Right
    } 
}