using System;
using UnityEngine;

namespace CosmicCuration.Enemy
{
    [CreateAssetMenu(fileName = "EnemyScriptableObject", menuName = "ScriptableObjects/EnemySO")]
    public class EnemyScriptableObject : ScriptableObject
    {
        public float spawnDistance;
        public float initialSpawnRate;
        public float minimumSpawnRate;
        public float difficultyDelta;
        public EnemyData enemyData;
    }

    [Serializable]
    public struct EnemyData
    {
        public int maxHealth;
        public float speed;
        public int damage;
        public int scoreToGrant;
    } 
}