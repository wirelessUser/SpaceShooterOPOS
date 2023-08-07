using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class UiService : MonoBehaviour
    {
        #region References

        [Header("MainMenu UI:")]
        private MainMenuController mainMenuController;
        [SerializeField] private MainMenuView mainMenuView;

        [Header("Gameplay UI:")]
        private GameplayUiController gameplayUiController;
        [SerializeField] private GameObject gameplayPanel;
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private Button playAgainButton;
        [SerializeField] private Button quitButton;
        #endregion

        #region Variables
        private int currentScore;
        #endregion

        #region Getters
        public MainMenuController GetMainMenuController() => mainMenuController;
        public GameplayUiController GetGameplayUiController() => gameplayUiController;
        #endregion

        private void Start()
        {
            MainMenuController mainMenuController = new MainMenuController(mainMenuView);
        }

        public void EnableGameOverUI()
        {
            gameplayPanel.SetActive(false);
            gameOverPanel.SetActive(true);
            playAgainButton.onClick.AddListener(OnPlayAgainClicked);
            quitButton.onClick.AddListener(OnQuitClicked);
        }

        private void OnPlayAgainClicked() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        private void OnQuitClicked() => Application.Quit();
    } 
}