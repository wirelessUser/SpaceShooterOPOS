using UnityEngine;
using UnityEngine.SceneManagement;

namespace CosmicCuration.UI
{
    public class UIService : MonoBehaviour
    {

        [Header("MainMenu UI:")]
        private MainMenuUiController mainMenuUIController;
        [SerializeField] private MainMenuView mainMenuView;

        [Header("Gameplay UI:")]
        private GameplayUiController gameplayUiController;
        [SerializeField] private GameplayUiView gameplayUiView;

        [Header("GameOver UI:")]
        private GameOverUIController gameOverUiController;
        [SerializeField] private GameOverUIView gameOverUiView;

        [Header("Options UI:")]
        private OptionsUiController optionsUiController;
        [SerializeField] private OptionsUiView optionsUiView;
        [SerializeField] private SoundSettingView soundSettingView;
        [SerializeField] private DifficultySettingView difficultySettingView;
        [SerializeField] private GameInfoView gameInfoView;
      
        public MainMenuUiController GetMainMenuController() => mainMenuUIController;
        public GameplayUiController GetGameplayUiController() => gameplayUiController;
        public OptionsUiController GetOptionsUiController() => optionsUiController;

        // Ui service will make screen views.
        private void Start()
        {
            mainMenuUIController = new MainMenuUiController(mainMenuView);
            EnableMainMenuUI();
        }

        public void EnableMainMenuUI() => mainMenuView.EnableView();

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