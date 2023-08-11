using CosmicCuration.PowerUps;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.UI
{
    public class GameplayUiController : IUIController
    {
        private GameplayUiView gameplayUiView;

        private int currentScore;
        public GameplayUiController(GameplayUiView gameplayUiView)
        {
            this.gameplayUiView = gameplayUiView;
            this.gameplayUiView.SetController(this);
        }

        public void IncrementScore(int scoreToIncrement)
        {
            currentScore += scoreToIncrement;
            gameplayUiView.UpdateScoreUI(currentScore);
        }

        public void ResetScore()
        {
            currentScore = 0;
            gameplayUiView.UpdateScoreUI(currentScore);
        }

        public void UpdateHealth(int healthToDisplay) => gameplayUiView.UpdateHealthUI(healthToDisplay);

        public void EnablePowerUpUi(PowerUpType powerUpType)
        {
            switch (powerUpType)
            {
                case PowerUpType.RapidFire:
                    gameplayUiView.EnableRapidFireText();
                    break;
                case PowerUpType.DoubleTurret:
                    gameplayUiView.EnableDoubleTurretText();
                    break;
            }
        }

        public void DisablePowerUpUi(PowerUpType powerUpType)
        {
            switch (powerUpType)
            {
                case PowerUpType.RapidFire:
                    gameplayUiView.DisableRapidFireText();
                    break;
                case PowerUpType.DoubleTurret:
                    gameplayUiView.DisableDoubleTurretText();
                    break;
            }
        }
    }
}
