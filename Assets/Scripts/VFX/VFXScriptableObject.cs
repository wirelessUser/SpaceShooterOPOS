using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VFXScriptableObject", menuName = "ScriptableObjects/VFXScriptableObject")]
public class VFXScriptableObject : ScriptableObject
{
    public List<VFXData> data;
}

[Serializable]
public struct VFXData
{
    public VFXType type;
    public VFXView prefab;
}