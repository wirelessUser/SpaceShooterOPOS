using UnityEngine;

/// <summary>
/// Represents the view component of an Enemy.
/// </summary>
public class EnemyView : MonoBehaviour
{
    private EnemyController enemyController;

    public void SetController(EnemyController enemyController) => this.enemyController = enemyController;
    
    private void Update() => enemyController.UpdateMotion();

    public void TakeBulletDamage(int damageToTake) => enemyController.TakeDamage(damageToTake);

    private void OnTriggerEnter2D(Collider2D collision) => enemyController?.OnEnemyCollided(collision.gameObject);
}