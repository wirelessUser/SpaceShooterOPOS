using UnityEngine;
using UnityEngine.SceneManagement;

namespace CosmicCuration.UI
{
    public class UIService : MonoBehaviour
    {

        [Header("MainMenu UI:")]
        private MainMenuUIController mainMenuUIController;
        [SerializeField] private MainMenuView mainMenuView;

        [Header("Gameplay UI:")]
        private GameplayUIController gameplayUIController;
        [SerializeField] private GameplayUIView gameplayUIView;

        [Header("GameOver UI:")]
        private GameOverUIController gameOverUiController;
        [SerializeField] private GameOverUIView gameOverUIView;

        [Header("Options UI:")]
        private OptionsUIController optionsUIController;
        [SerializeField] private OptionsUiView optionsUIView;
        private SoundSettingController soundSettingController;
        [SerializeField] private SoundSettingView soundSettingView;
        private DifficultySettingController difficultySettingController;
        [SerializeField] private DifficultySettingView difficultySettingView;
        private GameInfoController gameInfoController;
        [SerializeField] private GameInfoView gameInfoView;
      
        public MainMenuUIController GetMainMenuController() => mainMenuUIController;
        public GameplayUIController GetGameplayUiController() => gameplayUIController;
        public OptionsUIController GetOptionsUiController() => optionsUIController;

        // Ui service will make screen views.
        private void Start()
        {
            mainMenuUIController = new MainMenuUIController(mainMenuView);
            EnableMainMenuUI();
        }

        public void EnableMainMenuUI() => mainMenuUIController.EnableView();

        public void EnableGameplayUi() => gameplayUIController.EnableView();

        public void EnableOptionsScreen() => optionsUIController.EnableView();

        public void EnableSoundSettingScreen() => soundSettingController.EnableView();

        public void EnableDifficultySettingScreen() => difficultySettingController.EnableView();

        public void EnableGameInfoScreen() => gameInfoController.EnableView();

        public void EnableGameOverUI() => gameOverUiController.EnableView();

        public void StartGameplay()
        {
            gameplayUIController = new GameplayUIController(gameplayUIView);
            GameService.Instance.InstantiateGameplayObjects();
            EnableGameplayUi();
        }
    }
}