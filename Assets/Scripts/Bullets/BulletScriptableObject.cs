using UnityEngine;

namespace CosmicCuration.Bullets
{
    [CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObjects/BulletSO")]
    public class BulletScriptableObject : ScriptableObject
    {
        public float speed;
        public int damage;
    } 
}
