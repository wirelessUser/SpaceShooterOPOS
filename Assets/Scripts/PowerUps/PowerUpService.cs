using System;
using UnityEngine;

namespace CosmicCuration.PowerUps
{
    public class PowerUpService
    {
        private PowerUpPool powerUpPool;
        private PowerUpScriptableObject powerUpSO;

        private bool isSpawning;
        private float spawnTimer;

        public PowerUpService(PowerUpScriptableObject powerUpScriptableObject)
        {
            powerUpPool = new PowerUpPool();

            powerUpSO = powerUpScriptableObject;
            spawnTimer = powerUpSO.spawnRate;
            isSpawning = true;
        }

        public void Update()
        {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0)
            {
                SpawnPowerUps();
                ResetSpawnTimer();
            }
        }

        private void ResetSpawnTimer() => spawnTimer = powerUpSO.spawnRate;

        private void SpawnPowerUps()
        {
            if (isSpawning)
            {
                // Select a random powerup type from Shield/RapidFire/Turret.
                PowerUpType randomPowerUp = (PowerUpType)UnityEngine.Random.Range(0, Enum.GetValues(typeof(PowerUpType)).Length);

                PowerUpController powerUp = FetchPowerUp(randomPowerUp);

                // Set a random position of the fetched PowerUp using PowerUpController.SetPosition()
                powerUp.Configure(CalculateRandomSpawnPosition());
            }
        }

        private PowerUpController FetchPowerUp(PowerUpType randomPowerUp)
        {
            // for this random PowerUp type, fetch its data from powerUpSO. Data includes prefab and active duration for that type.
            PowerUpData randomPowerUpData = powerUpSO.powerUpData.Find(item => item.powerUpType == randomPowerUp);

            // Use this data to fetch a powerup instance from the powerUpPool.
            switch (randomPowerUp)
            {
                case PowerUpType.Shield:
                    return (PowerUpController)powerUpPool.GetPowerUp<Shield>(randomPowerUpData.powerUpPrefab, randomPowerUpData.activeDuration);
                case PowerUpType.DoubleTurret:
                    return (PowerUpController)powerUpPool.GetPowerUp<DoubleTurret>(randomPowerUpData.powerUpPrefab, randomPowerUpData.activeDuration);
                case PowerUpType.RapidFire:
                    return (PowerUpController)powerUpPool.GetPowerUp<RapidFire>(randomPowerUpData.powerUpPrefab, randomPowerUpData.activeDuration);
                default:
                    return new PowerUpController(randomPowerUpData.powerUpPrefab, randomPowerUpData.activeDuration);
            }
        }

        private Vector2 CalculateRandomSpawnPosition()
        {
            // Get the boundaries of the visible game screen
            float minX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
            float maxX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
            float minY = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
            float maxY = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

            // Generate random values for X and Y coordinates within the screen boundaries
            float randomX = UnityEngine.Random.Range(minX, maxX);
            float randomY = UnityEngine.Random.Range(minY, maxY);

            // Return the calculated random spawn position
            return new Vector2(randomX, randomY);
        }

        public void ReturnPowerUpToPool(PowerUpController powerUpToDestroy) => powerUpPool.ReturnItem(powerUpToDestroy);
    } 
}