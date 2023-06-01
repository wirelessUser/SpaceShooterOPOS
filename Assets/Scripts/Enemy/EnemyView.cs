using UnityEngine;

namespace CosmicCuration.Enemy
{
    public class EnemyView : MonoBehaviour, IDamageable
    {
        private EnemyController enemyController;

        public void SetController(EnemyController enemyController) => this.enemyController = enemyController;

        private void Update() => enemyController.UpdateMotion();

        private void OnTriggerEnter2D(Collider2D collision) => enemyController?.OnEnemyCollided(collision.gameObject);

        public void TakeDamage(int damageToTake) => enemyController.TakeDamage(damageToTake);
    } 
}