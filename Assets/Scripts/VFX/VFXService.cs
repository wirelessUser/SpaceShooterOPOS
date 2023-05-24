using UnityEngine;

public class VFXService
{
    private VFXScriptableObject vfxSO;
    private VFXPool vfxPool;

    public VFXService(VFXScriptableObject vfxSO)
    {
        this.vfxSO = vfxSO;
        vfxPool = new VFXPool();
    }

    public void SpawnVFXAtPosition(VFXType type, Vector2 spawnPosition)
    {
        /* TODO: 
         * Fetch the vfx Prefab for given type from vfxSO.
         * Fetch the vfxController from pool
         * Set the spawnPosition of the vfx.
         */
    }

    public void ReturnVFXToPool(VFXController vfxToReturn)
    {
        vfxPool.ReturnItem(vfxToReturn);
    }
}