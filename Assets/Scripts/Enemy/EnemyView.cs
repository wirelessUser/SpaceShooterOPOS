using UnityEngine;

namespace CosmicCuration.Enemy
{
    /// <summary>
    /// Represents the view component of an Enemy.
    /// </summary>
    public class EnemyView : MonoBehaviour, IDamageable
    {
        private EnemyController enemyController;

        public void SetController(EnemyController enemyController) => this.enemyController = enemyController;

        private void Update() => enemyController.UpdateMotion();

        private void OnTriggerEnter2D(Collider2D collision) => enemyController?.OnEnemyCollided(collision.gameObject);

        public void TakeDamage(int damageToTake) => enemyController.TakeDamage(damageToTake);
    } 
}