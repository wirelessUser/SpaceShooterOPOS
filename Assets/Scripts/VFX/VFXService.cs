using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.VFX
{
    public class VFXService
    {
        private List<VFXData> vfxData = new List<VFXData>();

        public VFXService(VFXScriptableObject vfxSO) => vfxData = vfxSO.vfxData;

        public void PlayVFXAtPosition(VFXType type, Vector2 spawnPosition)
        {
            VFXView prefabToSpawn = vfxData.Find(item => item.type == type).prefab;
            VFXController vfxToPlay = new VFXController(prefabToSpawn);
            vfxToPlay.Configure(spawnPosition);
        }
    } 
}