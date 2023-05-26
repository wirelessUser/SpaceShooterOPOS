using UnityEngine;

namespace CosmicCuration.VFX
{
    public class VFXService
    {
        private VFXView vfxPrefab;

        public VFXService(VFXView vfxPrefab)
        {
            this.vfxPrefab = vfxPrefab;
        }

        public void PlayVFXAtPosition(VFXType type, Vector2 spawnPosition)
        {
            VFXController vfxToPlay = new VFXController(vfxPrefab);
            vfxToPlay.Configure(type, spawnPosition);
        }
    } 
}