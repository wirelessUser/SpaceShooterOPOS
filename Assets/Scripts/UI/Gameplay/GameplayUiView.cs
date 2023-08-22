using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class GameplayUIView : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        [SerializeField] private Text healthText;
        [SerializeField] private GameObject rapidFireText;
        [SerializeField] private GameObject doubleTurretText;

        private GameplayUIController controller;

        public void SetController(GameplayUIController controllerToSet) => controller = controllerToSet;

        public void UpdateScoreUI(int scoreToIncrement) => scoreText.text = scoreToIncrement.ToString();

        public void UpdateHealthUI(int healthToDisplay) => healthText.text = healthToDisplay.ToString();

        public void EnableRapidFireText() => rapidFireText.SetActive(true);

        public void DisableRapidFireText() => rapidFireText.SetActive(false);

        public void EnableDoubleTurretText() => doubleTurretText.SetActive(true);

        public void DisableDoubleTurretText() => doubleTurretText.SetActive(false);
        
    }
}
