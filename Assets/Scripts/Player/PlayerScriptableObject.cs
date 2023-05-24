using UnityEngine;

[CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObject/PlayerSO")]
public class PlayerScriptableObject : ScriptableObject
{
    public int maxHealth;
    public float movementSpeed;
    public float rateOfFire;
}