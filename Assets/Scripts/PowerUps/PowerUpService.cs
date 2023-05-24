using System;
using UnityEngine;

public class PowerUpService
{
    private PowerUpPool powerUpPool;
    private PowerUpScriptableObject powerUpSO;
    
    private float spawnTimer;

    public PowerUpService(PowerUpScriptableObject powerUpScriptableObject)
    {
        powerUpSO = powerUpScriptableObject;
        powerUpPool = new PowerUpPool();
        ResetSpawnTimer();
    }

    private void ResetSpawnTimer()
    {
        spawnTimer = powerUpSO.spawnDuration;
    }

    private async void SpawnPowerUps()
    {
        /* TODO: 
         * Select a random powerup type from Shield/RapidFire/Turret.
         * for that random PowerUp type, fetch its data from powerUpSO. Data includes prefab and active duration for that type.
         * Use this data to fetch a powerup instance from the powerUpPool. 
         * Set a random position of the powerup fetched PowerUp using PowerUpController.SetPosition()
         */
        throw new NotImplementedException();
    }

    private Vector2 CalculateRandomSpawnPosition()
    {
        // TODO:
        // - Calculate a random spawn position within the visible game screen.
        // - Generate random values for X and Y coordinates within the screen boundaries.
        // - Clamp the spawn position to ensure it is within the visible game screen.
        // - Return the calculated random spawn position.
        throw new NotImplementedException();
    }

    public void ReturnPowerUpToPool(PowerUpView powerUpToDestroy)
    {
        // TODO: Deactivate the power-up view game object.
        // TODO: Return the power-up view to the powerUpViewPool.
    }
}