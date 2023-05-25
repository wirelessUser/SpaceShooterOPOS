using UnityEngine;

[CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObjects/PlayerSO")]
public class PlayerScriptableObject : ScriptableObject
{
    public int maxHealth;
    public float movementSpeed;
    public float defaultFireRate;
    public float rapidFireRate;
}