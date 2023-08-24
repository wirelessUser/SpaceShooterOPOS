using System;
using UnityEngine;

namespace CosmicCuration.Audio
{
    public class SoundService
    {
        private SoundScriptableObject soundScriptableObject;
        private AudioSource audioEffects;
        private AudioSource backgroundMusic;

        // TODO: Will not be using booleans. Create an enum called SFXState with Mute and Unmute as values, even if there are only 2 values for that enum, the enum gives more readability to our code.
        // TODO: Create a lambda method SetSFXState to update the mute state whenever needed.
        public bool isSoundEffectsMuted;

        public SoundService(SoundScriptableObject soundScriptableObject, AudioSource audioEffectSource, AudioSource bgMusicSource)
        {
            this.soundScriptableObject = soundScriptableObject;
            audioEffects = audioEffectSource;
            backgroundMusic = bgMusicSource;
            PlaybackgroundMusic(SoundType.BackgroundMusic, true);
        }

        public void PlaySoundEffects(SoundType soundType, bool loopSound = false)
        {
            if (isSoundEffectsMuted) return;

            AudioClip clip = GetSoundClip(soundType);
            if (clip != null)
            {
                audioEffects.loop = loopSound;
                audioEffects.clip = clip;
                audioEffects.PlayOneShot(clip);
            }
            else
                Debug.LogError("No Audio Clip selected.");
        }

        public void PlaybackgroundMusic(SoundType soundType, bool loopSound = false)
        {
            AudioClip clip = GetSoundClip(soundType);
            if (clip != null)
            {
                backgroundMusic.loop = loopSound;
                backgroundMusic.clip = clip;
                backgroundMusic.Play();
            }
            else
                Debug.LogError("No Audio Clip selected.");
        }

        public void StopBackgroundMusic(SoundType soundType)
        {
            AudioClip clip = GetSoundClip(soundType);
            if (clip != null)
            {
                backgroundMusic.Stop();
            }
            else
                Debug.LogError("No Audio Clip selected.");
        }

        private AudioClip GetSoundClip(SoundType soundType)
        {
            Sounds st = Array.Find(soundScriptableObject.audioList, item => item.soundType == soundType);
            if (st.audio != null)
                return st.audio;
            return null;
        }
    }
}