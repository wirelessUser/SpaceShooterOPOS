using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace CosmicCuration.UI
{
    public class GameplayUiView : MonoBehaviour, IUiView
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI healthText;

        private GameplayUiController controller;

        public void SetController(GameplayUiController controllerToSet)
        {
            controller = controllerToSet;
        }

        public void UpdateScoreUI(int scoreToIncrement)
        {
            scoreText.SetText(scoreToIncrement.ToString());
        }

        public void UpdateHealthUI(int healthToDisplay) => healthText.SetText(healthToDisplay.ToString());

        public void DisableView() => gameObject.SetActive(false);

        public void EnableView() => gameObject.SetActive(true);
    }
}
