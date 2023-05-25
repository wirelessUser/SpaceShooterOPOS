using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VFXScriptableObject", menuName = "ScriptableObjects/VFXScriptableObject")]
public class VFXScriptableObject : ScriptableObject
{
    public List<VFXData> data;
}