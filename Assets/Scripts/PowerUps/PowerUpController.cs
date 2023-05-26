using UnityEngine;
using CosmicCuration.Player;

namespace CosmicCuration.PowerUps
{
    public class PowerUpController : IPowerUp
    {
        private PowerUpView powerUpView;

        private bool isActive;
        private float activeDuration;
        private float activeTime;

        public PowerUpController(PowerUpView powerUpPrefab, float activeDuration)
        {
            powerUpView = Object.Instantiate(powerUpPrefab);
            powerUpView.SetController(this);
            this.activeDuration = activeDuration;
        }

        public void Configure(Vector2 spawnPosition)
        {
            isActive = false;
            activeTime = activeDuration;
            powerUpView.transform.position = spawnPosition;
            powerUpView.gameObject.SetActive(true);
            powerUpView.Toggle(true);
        }

        public void UpdateTimer()
        {
            if (isActive)
            {
                activeTime -= Time.deltaTime;
                if (activeTime <= 0)
                    Deactivate();
            }
        }

        public void PowerUpTriggerEntered(GameObject collidedObject)
        {
            if (collidedObject.GetComponent<PlayerView>() != null)
                Activate();
        }

        public virtual void Activate()
        {
            isActive = true;
            powerUpView.Toggle(false);
        }

        public virtual void Deactivate()
        {
            isActive = false;
            powerUpView.gameObject.SetActive(false);
            Object.Destroy(powerUpView);
        }
    } 
}