using System;
using UnityEngine;

namespace CosmicCuration.Audio
{
    /// <summary>
    /// Represents a sound configuration in the game.
    /// </summary>
    [Serializable]
    public struct Sounds
    {
        public SoundType soundType;
        public AudioClip audio;
    }
}