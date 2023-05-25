using UnityEngine;

namespace CosmicCuration.Audio
{
    [CreateAssetMenu(fileName = "SoundScriptableObject", menuName = "ScriptableObjects/SoundScriptableObject")]
    public class SoundScriptableObject : ScriptableObject
    {
        /// <summary>
        /// Array of sound configurations.
        /// </summary>
        public Sounds[] audioList;
    } 
}
