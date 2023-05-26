using System;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.PowerUps
{
    [CreateAssetMenu(fileName = "PowerUpScriptableObject", menuName = "ScriptableObjects/PowerUpScriptableObject")]
    public class PowerUpScriptableObject : ScriptableObject
    {
        public float spawnRate;
        public List<PowerUpData> powerUpData;
    }

    /// <summary>
    /// Data Container for a particular type of PowerUp.
    /// </summary>
    [Serializable]
    public struct PowerUpData
    {
        public PowerUpType powerUpType;
        public PowerUpView powerUpPrefab;
        public float activeDuration;
    } 
}