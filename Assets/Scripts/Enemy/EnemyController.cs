using UnityEngine;

public class EnemyController : IDamageable
{
    private EnemyView enemyView;
    private EnemyScriptableObject enemySO;

    private int currentHealth;

    public EnemyController(EnemyView enemyPrefab, EnemyScriptableObject enemySO)
    {
        enemyView = Object.Instantiate(enemyPrefab);
        enemyView.SetController(this);

        this.enemySO = enemySO;
        currentHealth = enemySO.health;
    }

    public void SetPosition(Vector3 positionToSet)
    {
        enemyView.transform.position = positionToSet;
    }

    public void TakeDamage(int damageToTake)
    {
        currentHealth -= damageToTake;
        if(currentHealth <= 0)
        {
            EnemyDestroyed();
        }
    }

    public void UpdateMotion()
    {
        enemyView.transform.Translate(Vector2.up * Time.deltaTime * enemySO.speed);
    }

    public void OnEnemyCollided(GameObject collidedGameObject)
    {
        // TODO : Handle Enemy Collision Logic.
    }

    private void EnemyDestroyed()
    {
        // TODO: Handle Enemy Death Logic.
    }

}