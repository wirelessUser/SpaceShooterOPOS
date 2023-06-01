using UnityEngine;

namespace CosmicCuration.PowerUps
{
    public class PowerUpView : MonoBehaviour
    {
        private PowerUpController powerUpController;

        public void SetController(PowerUpController controller) => powerUpController = controller;

        private void OnTriggerEnter2D(Collider2D collision) => powerUpController?.PowerUpTriggerEntered(collision.gameObject);
    } 
}