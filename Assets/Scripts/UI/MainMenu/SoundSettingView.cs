using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CosmicCuration.UI
{
    public class SoundSettingView : MonoBehaviour, IUiView
    {

        [SerializeField] private Button SoundBtn;
        [SerializeField] private Button MusicBtn;
        [SerializeField] private Button backButton;

        private void Awake()
        {
            SoundBtn.onClick.AddListener(OnClickSoundBtn);
            MusicBtn.onClick.AddListener(OnClickMusicBtn);
            backButton.onClick.AddListener(OnClickBackBtn);
        }

        public void DisableView() => gameObject.SetActive(false);

        public void EnableView() => gameObject.SetActive(true);

        private void OnClickSoundBtn()
        {

        }

        private void OnClickMusicBtn()
        {

        }
        private void OnClickBackBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableOptionsScreen();
        }
    }
}
