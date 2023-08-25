using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.UI
{
    public class OptionsUIController
    {
        private OptionsUiView UIView;

        public OptionsUIController(OptionsUiView optionsUiView)
        {
            UIView = optionsUiView;
            UIView.SetController(this);
        }

        public void DisableView() => UIView.gameObject.SetActive(false);

        public void EnableView() => UIView.gameObject.SetActive(true);

        public void OnClickSoundSettingBtn()
        {
            DisableView();
            GameService.Instance.UIService.EnableSoundSettingScreen();
        }

        public void OnClickDifficultySettingBtn()
        {
            DisableView();
            GameService.Instance.UIService.EnableDifficultySettingScreen();
        }

        public void OnClcikGameInfoBtn()
        {
            DisableView();
            GameService.Instance.UIService.EnableGameInfoScreen();
        }

        public void OnClickBackBtn()
        {
            DisableView();
            GameService.Instance.UIService.EnableMainMenuUI();
        }
    }
}
