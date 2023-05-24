using System;
using UnityEngine;

/// <summary>
/// This class handles playing sound effects and background music in the game.
/// </summary>
public class SoundService
{
    private AudioSource audioEffects;
    private AudioSource backgroundMusic;
    private SoundScriptableObject soundSO;

    public SoundService(SoundScriptableObject soundScriptableObject, AudioSource audioEffectSource, AudioSource bgMusicSource)
    {
        soundSO = soundScriptableObject;
        audioEffects = audioEffectSource;
        backgroundMusic = bgMusicSource;
        PlaybackgroundMusic(SoundType.BackgroundMusic, true);
    }

    /// <summary>
    /// Plays the specified sound effect.
    /// </summary>
    /// <param name="soundType">The type of the sound effect to play.</param>
    /// <param name="loopSound">Specifies whether the sound should loop or not.</param>
    public void PlaySoundEffects(SoundType soundType, bool loopSound = false)
    {
        AudioClip clip = GetSoundClip(soundType);
        if (clip != null)
        {
            audioEffects.loop = loopSound;
            audioEffects.PlayOneShot(clip);
        }
        else
        {
            Debug.LogError("No Audio Clip selected.");
        }
    }

    /// <summary>
    /// Plays the background music.
    /// </summary>
    /// <param name="soundType">The type of the background music to play.</param>
    /// <param name="loopSound">Specifies whether the background music should loop or not.</param>
    private void PlaybackgroundMusic(SoundType soundType, bool loopSound = false)
    {
        AudioClip clip = GetSoundClip(soundType);
        if (clip != null)
        {
            backgroundMusic.loop = loopSound;
            backgroundMusic.PlayOneShot(clip);
        }
        else
        {
            Debug.LogError("No Audio Clip selected.");
        }
    }

    /// <summary>
    /// Retrieves the audio clip associated with the specified sound type.
    /// </summary>
    /// <param name="soundType">The type of the sound.</param>
    /// <returns>The audio clip associated with the sound type, or null if not found.</returns>
    private AudioClip GetSoundClip(SoundType soundType)
    {
        Sounds st = Array.Find(soundSO.audioList, item => item.soundType == soundType);
        if (st.audio != null)
        {
            return st.audio;
        }
        return null;
    }
}