using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXView : MonoBehaviour
{
    private VFXController controller;

    [SerializeField] private List<VFXData> particleSystemMap;
    private ParticleSystem currentPlayingVFX;

    public void SetController(VFXController controllerToSet)
    {
        controller = controllerToSet;
    }

    public void ConfigureAndPlay(VFXType type, Vector2 positionToSet)
    {
        foreach(VFXData item in particleSystemMap)
        {
            if (item.type == type)
            {
                item.particleSystem.transform.position = positionToSet;
                item.particleSystem.gameObject.SetActive(true);
                currentPlayingVFX = item.particleSystem;
                // item.particleSystem.Play();
            }
            else
                item.particleSystem.gameObject.SetActive(false);
        }
        gameObject.SetActive(true);
    }

    private void Update()
    {
        if(currentPlayingVFX != null)
        {
            if(currentPlayingVFX.isStopped)
            {
                currentPlayingVFX.gameObject.SetActive(false);
                currentPlayingVFX = null;
                controller.OnParticleEffectCompleted();
                gameObject.SetActive(false);
            }
        }
    }

}

[Serializable]
public struct VFXData
{
    public VFXType type;
    public ParticleSystem particleSystem;
}