using UnityEngine;

/// <summary>
/// Represents the view component of an Enemy.
/// </summary>
public class EnemyView : MonoBehaviour
{
    private EnemyController enemyController;

    public void SetController(EnemyController enemyController) => this.enemyController = enemyController;
    
    private void Update() => enemyController.UpdateMotion();
    
    private void OnCollisionEnter(Collision collision) => enemyController?.OnEnemyCollided(collision.gameObject);
}