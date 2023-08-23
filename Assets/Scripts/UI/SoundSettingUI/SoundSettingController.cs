using CosmicCuration.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.UI
{
    public class SoundSettingController
    {
        private SoundSettingView UIView;
        private bool isSoundMuted;
        private bool isMusicMuted;


        public SoundSettingController(SoundSettingView soundSettingView)
        {
            UIView = soundSettingView;
            UIView.SetController(this);
        }

        public void DisableView() => UIView.gameObject.SetActive(false);

        public void EnableView() => UIView.gameObject.SetActive(true);

        public void OnClickSoundBtn()
        {
            if (!isSoundMuted)
            {
                isSoundMuted = true;
                GameService.Instance.GetSoundService().isSoundEffectsMuted = isSoundMuted;
            }
            else
            {
                isSoundMuted = false;
                GameService.Instance.GetSoundService().isSoundEffectsMuted = isSoundMuted;
            }
        }

        public void OnClickMusicBtn()
        {
            if (!isMusicMuted)
            {
                isMusicMuted = true;
                GameService.Instance.GetSoundService().StopBackgroundMusic(SoundType.BackgroundMusic);
            }
            else
            {
                isMusicMuted = false;
                GameService.Instance.GetSoundService().PlaybackgroundMusic(SoundType.BackgroundMusic);
            }
        }

        public void OnClickBackBtn()
        {
            DisableView();
            GameService.Instance.GetUIService().EnableOptionsScreen();
        }
    }
}
