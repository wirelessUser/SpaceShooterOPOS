using System;
public class VFXPool : GenericObjectPool<VFXController>
{
    private VFXView currentVFXPrefab;

    public VFXController GetVFX<IT>(VFXView vfxPrefab) where IT : VFXController
    {
        currentVFXPrefab = vfxPrefab;
        return GetItem<IT>();
    }

    protected override VFXController CreateItem<IT>()
    {
        VFXController newVFXController;

        if (typeof(IT) == typeof(EnemyExplosion))
            newVFXController = new EnemyExplosion(currentVFXPrefab);
        else if (typeof(IT) == typeof(PlayerExplosion))
            newVFXController = new PlayerExplosion(currentVFXPrefab);
        else if (typeof(IT) == typeof(BulletHitExplosion))
            newVFXController = new BulletHitExplosion(currentVFXPrefab);
        else
            throw new NotSupportedException($"Power-up type '{typeof(IT)}' is not supported.");

        return newVFXController;
    }
}