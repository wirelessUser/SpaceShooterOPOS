using UnityEngine;
using TMPro;

/// <summary>
/// This class handles updating the UI elements in the game.
/// </summary>
public class UIService
{
    TextMeshProUGUI scoreText;
    TextMeshProUGUI healthText;

    private int currentScore;

    public UIService(TextMeshProUGUI scoreText, TextMeshProUGUI healthText)
    {
        this.scoreText = scoreText;
        this.healthText = healthText;
        currentScore = 0;
    }

    /// <summary>
    /// Increments the score by the specified amount and updates the score UI element.
    /// </summary>
    /// <param name="scoreToIncrement">The amount to increment the score.</param>
    public void IncrementScore(int scoreToIncrement)
    {
        currentScore += scoreToIncrement;
        scoreText.SetText(currentScore.ToString());
    }

    /// <summary>
    /// Updates the health UI element with the specified health value.
    /// </summary>
    /// <param name="healthToDisplay">The health value to display.</param>
    public void UpdateHealthUI(int healthToDisplay)
    {
        healthText.SetText(healthToDisplay.ToString());
    }
}