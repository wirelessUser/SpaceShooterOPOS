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
    }
}
