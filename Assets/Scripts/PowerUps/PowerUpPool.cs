using System;

public class PowerUpPool : GenericObjectPool<IPowerUp>
{
    private PowerUpView currentPowerUpPrefab;
    private float currentActiveDuration;

    public IPowerUp GetPowerUp<IT>(PowerUpView powerUpPrefab, float activeDuration) where IT : IPowerUp
    {
        currentPowerUpPrefab = powerUpPrefab;
        currentActiveDuration = activeDuration;
        return GetItem<IT>();
    }

    protected override IPowerUp CreateItem<IT>()
    {
        PowerUpController newPowerUp;

        if (typeof(IT) == typeof(Shield))
            newPowerUp = new Shield(currentPowerUpPrefab, currentActiveDuration);
        else if (typeof(IT) == typeof(DoubleTurret))
            newPowerUp = new DoubleTurret(currentPowerUpPrefab, currentActiveDuration);
        else if (typeof(IT) == typeof(RapidFire))
            newPowerUp = new RapidFire(currentPowerUpPrefab, currentActiveDuration);
        else
            throw new NotSupportedException($"Power-up type '{typeof(IT)}' is not supported.");

        return newPowerUp;
    }
}