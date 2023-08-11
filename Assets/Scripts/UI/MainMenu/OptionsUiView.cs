using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class OptionsUiView : MonoBehaviour, IUiView
    {
        [SerializeField] private Button SoundSettingBtn;
        [SerializeField] private Button DifficultySettingBtn;
        [SerializeField] private Button GameInfoBtn;
        [SerializeField] private Button backButton;

        private void Awake()
        {
            SoundSettingBtn.onClick.AddListener(OnClickSoundSettingBtn);
            DifficultySettingBtn.onClick.AddListener(OnClickDifficultySettingBtn);
            GameInfoBtn.onClick.AddListener(OnClcikGameInfoBtn);
            backButton.onClick.AddListener(OnClickBackBtn);
        }
        public void DisableView() => gameObject.SetActive(false);

        public void EnableView() => gameObject.SetActive(true);

        private void OnClickSoundSettingBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableSoundSettingScreen();
        }

        private void OnClickDifficultySettingBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableDifficultySettingScreen();
        }

        private void OnClcikGameInfoBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableGameInfoScreen();
        }

        private void OnClickBackBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableMainMenuUi();
        }
    }
}
