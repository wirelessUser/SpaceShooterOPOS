using UnityEngine;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class GameInfoView : MonoBehaviour, IUiView
    {
        [SerializeField] private Button backButton;

        private void Awake() => backButton.onClick.AddListener(OnClickBackBtn);
        
        public void DisableView() => gameObject.SetActive(false);

        public void EnableView() => gameObject.SetActive(true);

        private void OnClickBackBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableOptionsScreen();
        }
    }
}
