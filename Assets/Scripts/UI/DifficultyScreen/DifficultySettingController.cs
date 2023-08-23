using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.UI
{
    public class DifficultySettingController
    {
        private DifficultySettingView UIView;

        public DifficultySettingController(DifficultySettingView difficultySettingView)
        {
            UIView = difficultySettingView;
            UIView.SetController(this);
        }

        public void DisableView() => UIView.gameObject.SetActive(false);

        public void EnableView() => UIView.gameObject.SetActive(true);

        public void OnClickEasyBtn() => GameService.Instance.GetDifficultyService().currentDifficultyState = DifficultyState.Easy;

        public void OnClickMediumBtn() => GameService.Instance.GetDifficultyService().currentDifficultyState = DifficultyState.Medium;

        public void OnClickHardBtn() => GameService.Instance.GetDifficultyService().currentDifficultyState = DifficultyState.Hard;

        public void OnClickBackBtn()
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
