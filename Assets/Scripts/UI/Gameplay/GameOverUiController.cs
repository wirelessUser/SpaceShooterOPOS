using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CosmicCuration.UI
{
    public class GameOverUIController
    {
        private GameOverUIView UIView;

       public GameOverUIController(GameOverUIView gameOverUIView)
        {
            UIView = gameOverUIView;
            UIView.SetController(this);
        }

        public void DisableView() => UIView.gameObject.SetActive(false);

        public void EnableView() => UIView.gameObject.SetActive(true);

        public void OnPlayAgainClicked() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        public void OnQuitClicked() => Application.Quit();
    }
}
