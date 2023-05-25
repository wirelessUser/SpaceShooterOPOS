using TMPro;

namespace CosmicCuration.UI
{
    /// <summary>
    /// This class handles updating the UI elements in the game.
    /// </summary>
    public class UIService
    {
        TextMeshProUGUI scoreText;
        TextMeshProUGUI healthText;

        private int currentScore;
        private const string scorePrefix = "Score: ";
        private const string healthPrefix = "Health: ";

        public UIService(TextMeshProUGUI scoreText, TextMeshProUGUI healthText)
        {
            this.scoreText = scoreText;
            this.healthText = healthText;
            currentScore = 0;
            IncrementScore(currentScore);
        }

        /// <summary>
        /// Increments the score by the specified amount and updates the score UI element.
        /// </summary>
        /// <param name="scoreToIncrement">The amount to increment the score.</param>
        public void IncrementScore(int scoreToIncrement)
        {
            currentScore += scoreToIncrement;
            scoreText.SetText(scorePrefix + currentScore.ToString());
        }

        /// <summary>
        /// Updates the health UI element with the specified health value.
        /// </summary>
        /// <param name="healthToDisplay">The health value to display.</param>
        public void UpdateHealthUI(int healthToDisplay)
        {
            healthText.SetText(healthPrefix + healthToDisplay.ToString());
        }
    } 
}