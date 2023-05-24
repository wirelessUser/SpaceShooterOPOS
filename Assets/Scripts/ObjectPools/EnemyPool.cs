public class EnemyPool : GenericObjectPool<EnemyController>
{
    private EnemyView enemyPrefab;
    private EnemyScriptableObject enemySO;

    public EnemyPool(EnemyView enemyPrefab, EnemyScriptableObject enemySO)
    {
        this.enemyPrefab = enemyPrefab;
        this.enemySO = enemySO;
    }

    public EnemyController GetEnemy()
    {
        return GetItem<EnemyController>();
    }

    protected override EnemyController CreateItem<IT>()
    {
        EnemyController newEnemy = new EnemyController(enemyPrefab, enemySO);
        return newEnemy;
    }
}