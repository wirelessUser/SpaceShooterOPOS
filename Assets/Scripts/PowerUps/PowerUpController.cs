using UnityEngine;

public class PowerUpController : IPowerUp
{
    private PowerUpView powerUpView;

    private float activeTime;

    public PowerUpController(PowerUpView powerUpPrefab, float activeDuration)
    {
        powerUpView = Object.Instantiate(powerUpPrefab);
        powerUpView.SetController(this);
        activeTime = activeDuration;
    }

    public void SetPosition(Vector2 spawnPosition) => powerUpView.transform.position = spawnPosition;
    
    public void UpdateTimer()
    {
        if (activeTime <= 0)
            Deactivate();
        else
            activeTime -= Time.deltaTime;
    }

    public void PowerUpTriggerEntered(GameObject colidedObject)
    {
        // TODO: Implement collider trigger logic for powerUp.
    }

    public virtual void Activate() { }

    public virtual void Deactivate() { }
}