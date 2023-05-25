using UnityEngine;
using System;
using System.Collections.Generic;

public class VFXPool : GenericObjectPool<VFXController>
{
    private VFXView vfxPrefab;

    public VFXPool(VFXView vfxPrefab) => this.vfxPrefab = vfxPrefab;
    
    public VFXController GetVFX()
    {
        return GetItem<VFXController>();
    }

    protected override VFXController CreateItem<IT>()
    {
        VFXController newVFXController = new VFXController(vfxPrefab);
        return newVFXController;
    }
}