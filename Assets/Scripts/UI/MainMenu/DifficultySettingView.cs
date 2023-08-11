using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class DifficultySettingView : MonoBehaviour,IUiView
    {
        [SerializeField] private Button easyBtn;
        [SerializeField] private Button mediumBtn;
        [SerializeField] private Button hardBtn;
        [SerializeField] private Button backButton;

        private void Awake()
        {
            easyBtn.onClick.AddListener(OnClickEasyBtn);
            mediumBtn.onClick.AddListener(OnClickMediumBtn);
            hardBtn.onClick.AddListener(OnClickHardBtn);
            backButton.onClick.AddListener(OnClickBackBtn);
        }
        public void DisableView() => gameObject.SetActive(false);

        public void EnableView() => gameObject.SetActive(true);

        private void OnClickEasyBtn() => GameService.Instance.currentDifficultyState = DifficultyState.Easy;

        private void OnClickMediumBtn() => GameService.Instance.currentDifficultyState = DifficultyState.Medium;

        private void OnClickHardBtn() => GameService.Instance.currentDifficultyState = DifficultyState.Hard;
        
        private void OnClickBackBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableOptionsScreen();
        }
    }

    public enum DifficultyState
    {
        Easy,
        Medium,
        Hard
    }
}
