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

    [Serializable]
    public struct PowerUpData
    {
        public PowerUpType powerUpType;
        public PowerUpView powerUpPrefab;
        public float activeDuration;
    } 
}