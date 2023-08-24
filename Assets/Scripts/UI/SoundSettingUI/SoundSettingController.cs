using CosmicCuration.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.UI
{
    public class SoundSettingController
    {
        private SoundSettingView UIView;

        // TODO: These booleans need to be converted to Enums.
        // TODO: These enums and its current value should be stored in SoundService.
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
                // TODO: Directly call a method MuteSFX() in SoundService here. The current mute state should be checked inside the sound service, not here.
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
            // TODO: Directly call a method MuteMusic() in SoundService here. The current mute state should be checked or updated inside the sound service, not here.
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
