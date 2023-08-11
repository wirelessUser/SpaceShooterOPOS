using UnityEngine;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class MainMenuView : MonoBehaviour, IUiView
    {
        [SerializeField] private Button playButton;
        [SerializeField] private Button optionsButton;

        private MainMenuUiController controller;

        private void Awake()
        {
            playButton.onClick.AddListener(OnClickPlayBtn);
            optionsButton.onClick.AddListener(OnClickOptionsBtn);
        }

        public void SetController(MainMenuUiController controllerToSet) => controller = controllerToSet;
        
        public void DisableView() => gameObject.SetActive(false);

        public void EnableView() => gameObject.SetActive(true);

        private void OnClickPlayBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().StartGameplay();
        }

        private void OnClickOptionsBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableOptionsScreen();
        }
    }
}
