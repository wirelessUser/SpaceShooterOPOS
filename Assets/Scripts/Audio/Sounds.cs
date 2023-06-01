using System;
using UnityEngine;

namespace CosmicCuration.Audio
{
    [Serializable]
    public struct Sounds
    {
        public SoundType soundType;
        public AudioClip audio;
    }
}