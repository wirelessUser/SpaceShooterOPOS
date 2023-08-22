using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class GameOverUIView : MonoBehaviour
    {
        private GameOverUIController controller;

       [SerializeField] private Button playAgainButton;
       [SerializeField] private Button quitButton;

        public void SetController(GameOverUIController controllerToSet) => controller = controllerToSet;

        private void OnEnable()
        {
            GameService.Instance.SetTimeScale(0);
            playAgainButton.onClick.AddListener(PlayAgainClicked);
            quitButton.onClick.AddListener(QuitClicked);
        }

        private void PlayAgainClicked() => controller.OnPlayAgainClicked();

        private void QuitClicked() => controller.OnQuitClicked();
    }
}
