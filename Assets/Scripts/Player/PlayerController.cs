using UnityEngine;

public class PlayerController : IDamageable
{
    private PlayerView playerView;
    private PlayerScriptableObject playerSO;
    private BulletPool bulletPool;

    private WeaponMode currentWeaponMode;
    private int currentHealth;
    private float currentRateOfFire;

    #region Initialization

    public PlayerController(PlayerView playerViewPrefab, PlayerScriptableObject playerSO, BulletPool bulletPool)
    {
        playerView = Object.Instantiate(playerViewPrefab);
        playerView.SetController(this);
        this.playerSO = playerSO;

        InitializeVariables();
    }

    private void InitializeVariables()
    {
        currentHealth = playerSO.maxHealth;
        currentRateOfFire = playerSO.rateOfFire;
        currentWeaponMode = WeaponMode.SingleCanon;
    }

    #endregion

    public void TakeDamage(int damageToTake)
    {
        // TODO: Implement logic to take damage.
    }

    private void PlayerDeath()
    {
        // TODO: Implement player death logic
    }

    public void HandlePlayerMovement()
    {
        // TODO: Implement player movement logic
    }

    public void FireWeapon()
    {
        // TODO: Fire weapons using bullet pool according to player's current weapon mode.
    }

    /// <summary>
    /// Fires a bullet from the given position.
    /// </summary>
    /// <param name="fireLocation">The position from which to fire the bullet.</param>
    private void FireBulletAtPosition(Transform fireLocation)
    {
        // TODO: Implement the logic to fire a bullet from the given position.
        // Get a bullet from the playerBulletPool.
        // Set the bullet's position and rotation to the fireLocation.
        // Activate the bullet.
    }

    public void ResetBullet(BulletController bulletToReset)
    {
        bulletPool.ReturnItem(bulletToReset);
    }

    public void ToggleShield(bool setActive)
    {

    }

    public void ToggleDoubleTurret(bool setActive)
    {

    }

    public void OnPlayerCollided(GameObject collidedGameObject)
    {

    }

    public void ChangeRateOfFire(float newRateOfFire) => currentRateOfFire = newRateOfFire;
    public void ResetRateOfFire() => currentRateOfFire = playerSO.rateOfFire;
}

public enum WeaponMode
{
    SingleCanon,
    DoubleTurret
}