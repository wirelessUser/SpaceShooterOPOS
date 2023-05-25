public class EnemyPool : GenericObjectPool<EnemyController>
{
    private EnemyView enemyPrefab;
    private EnemyData enemyData;

    public EnemyPool(EnemyView enemyPrefab, EnemyData enemyData)
    {
        this.enemyPrefab = enemyPrefab;
        this.enemyData = enemyData;
    }

    public EnemyController GetEnemy()
    {
        return GetItem<EnemyController>();
    }

    protected override EnemyController CreateItem<IT>()
    {
        EnemyController newEnemy = new EnemyController(enemyPrefab, enemyData);
        return newEnemy;
    }
}