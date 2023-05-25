using UnityEngine;

public class EnemyController : IDamageable
{
    private EnemyView enemyView;
    private EnemyData enemyData;

    private int currentHealth;
    private Vector2 moveDirection;

    public EnemyController(EnemyView enemyPrefab, EnemyData enemyData)
    {
        enemyView = Object.Instantiate(enemyPrefab);
        enemyView.SetController(this);

        this.enemyData = enemyData;
        currentHealth = enemyData.maxHealth;
    }

    public void Configure(Vector3 positionToSet, EnemyOrientation enemyOrientation)
    {
        currentHealth = enemyData.maxHealth;
        enemyView.transform.position = positionToSet;
        enemyView.gameObject.SetActive(true);
        SetEnemyOrientation(enemyOrientation);
    }

    private void SetEnemyOrientation(EnemyOrientation orientation)
    {
        // Rotate the enemy based on its orientation
        switch (orientation)
        {
            case EnemyOrientation.Left:
                enemyView.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                moveDirection = enemyView.transform.right;
                break;

            case EnemyOrientation.Right:
                enemyView.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
                moveDirection = -enemyView.transform.right;
                break;

            case EnemyOrientation.Up:
                enemyView.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                moveDirection = enemyView.transform.up;
                break;

            case EnemyOrientation.Down:
                enemyView.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
                moveDirection = -enemyView.transform.up;
                break;
        }
    }

    public void TakeDamage(int damageToTake)
    {
        currentHealth -= damageToTake;
        GameService.Instance.GetSoundService().PlaySoundEffects(SoundType.EnemyDamaged);
        if (currentHealth <= 0)
            EnemyDestroyed();
    }

    public void UpdateMotion() => enemyView.transform.Translate(moveDirection * Time.deltaTime * enemyData.speed);

    public void OnEnemyCollided(GameObject collidedGameObject)
    {
        // TODO : Handle Enemy Collision Logic.
        if(collidedGameObject.GetComponent<PlayerView>() != null)
        {
            GameService.Instance.GetPlayerService().GetPlayerController().TakeDamage(enemyData.damage);
            EnemyDestroyed();
        }
    }

    private void EnemyDestroyed()
    {
        // TODO: Handle Enemy Death Logic.
        enemyView.gameObject.SetActive(false);
        // Add Particle Effects.
        GameService.Instance.GetEnemyService().ReturnEnemyToPool(this);
        GameService.Instance.GetSoundService().PlaySoundEffects(SoundType.EnemyDeath);
    }
}