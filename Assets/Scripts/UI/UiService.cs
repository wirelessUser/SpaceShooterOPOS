using UnityEngine;
using UnityEngine.SceneManagement;

namespace CosmicCuration.UI
{
    public class UiService : MonoBehaviour
    {
        #region References

        [Header("MainMenu UI:")]
        private MainMenuUiController mainMenuUiController;
        [SerializeField] private MainMenuView mainMenuView;

        [Header("Gameplay UI:")]
        private GameplayUiController gameplayUiController;
        [SerializeField] private GameplayUiView gameplayUiView;

        [Header("GameOver UI:")]
        private GameOverUiController gameOverUiController;
        [SerializeField] private GameOverUiView gameOverUiView;

        [Header("Options UI:")]
        private OptionsUiController optionsUiController;
        [SerializeField] private OptionsUiView optionsUiView;
        [SerializeField] private SoundSettingView soundSettingView;
        [SerializeField] private DifficultySettingView difficultySettingView;
        [SerializeField] private GameInfoView gameInfoView;
        #endregion

        #region Getters
        public MainMenuUiController GetMainMenuController() => mainMenuUiController;
        public GameplayUiController GetGameplayUiController() => gameplayUiController;
        public OptionsUiController GetOptionsUiController() => optionsUiController;
        #endregion

        // Ui service will make screen views.
        private void Start()
        {
            mainMenuUiController = new MainMenuUiController(mainMenuView);
            EnableMainMenuUi();
        }

        public void EnableMainMenuUi() => mainMenuView.EnableView();

        public void EnableGameplayUi() => gameplayUiView.EnableView();

        public void EnableOptionsScreen() => optionsUiView.EnableView();

        public void EnableSoundSettingScreen() => soundSettingView.EnableView();

        public void EnableDifficultySettingScreen() => difficultySettingView.EnableView();

        public void EnableGameInfoScreen() => gameInfoView.EnableView();

        public void EnableGameOverUI() => gameOverUiView.EnableView();

        public void StartGameplay()
        {
            gameplayUiController = new GameplayUiController(gameplayUiView);
            GameService.Instance.InstantiateGameplayObjects();
            EnableGameplayUi();
        }
    }
}