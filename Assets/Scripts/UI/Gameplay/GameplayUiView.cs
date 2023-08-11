using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class GameplayUiView : MonoBehaviour, IUiView
    {
        [SerializeField] private Text scoreText;
        [SerializeField] private Text healthText;
        [SerializeField] private GameObject rapidFireText;
        [SerializeField] private GameObject doubleTurretText;

        private GameplayUiController controller;

        public void SetController(GameplayUiController controllerToSet) => controller = controllerToSet;

        public void UpdateScoreUI(int scoreToIncrement) => scoreText.text = scoreToIncrement.ToString();

        public void UpdateHealthUI(int healthToDisplay) => healthText.text = healthToDisplay.ToString();

        public void DisableView() => gameObject.SetActive(false);

        public void EnableView() => gameObject.SetActive(true);

        public void EnableRapidFireText() => rapidFireText.SetActive(true);

        public void DisableRapidFireText() => rapidFireText.SetActive(false);

        public void EnableDoubleTurretText() => doubleTurretText.SetActive(true);

        public void DisableDoubleTurretText() => doubleTurretText.SetActive(false);
        
    }
}
