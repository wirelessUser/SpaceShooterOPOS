using UnityEngine;

/// <summary>
/// Represents the view component of a PowerUp object.
/// </summary>
public class PowerUpView : MonoBehaviour
{
    private PowerUpController powerUpController;

    public void SetController(PowerUpController controller) => powerUpController = controller;
    
    public void Update() => powerUpController?.UpdateTimer();

    private void OnTriggerEnter2D(Collider2D collision) => powerUpController?.PowerUpTriggerEntered(collision.gameObject);
}