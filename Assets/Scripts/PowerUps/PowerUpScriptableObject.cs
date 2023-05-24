using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpScriptableObject", menuName = "ScriptableObjects/PowerUpScriptableObject")]
public class PowerUpScriptableObject : ScriptableObject
{
    public float spawnDuration;
    public List<PowerUpData> powerUpData;
}

[Serializable]
public struct PowerUpData
{
    public PowerUps powerUpType;
    public PowerUpView powerUpPrefab;
    public float activeDuration;
}