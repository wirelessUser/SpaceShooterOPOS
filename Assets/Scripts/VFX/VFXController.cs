using UnityEngine;

public class VFXController
{
    private VFXView vfxView;

    public VFXController(VFXView vfxPrefab)
    {
        vfxView = Object.Instantiate(vfxPrefab);
        vfxView.SetController(this);
    }

    public void SetPosition(Vector2 positionToSet)
    {
        vfxView.transform.position = positionToSet;
    }

    public void OnParticleEffectCompleted()
    {
        // TODO: implementn logic to reset this vfx when done playing.
    }
}