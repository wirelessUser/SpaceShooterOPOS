using UnityEngine;

/// <summary>
/// Handles buisness logic for a bullet.
/// </summary>
public class BulletController : IBullet
{
    private BulletView bulletView;
    private BulletScriptableObject bulletScriptableObject;

    public BulletController(BulletView bulletViewPrefab, BulletScriptableObject bulletScriptableObject)
    {
        bulletView = Object.Instantiate(bulletViewPrefab);
        bulletView.SetController(this);
        this.bulletScriptableObject = bulletScriptableObject;
    }

    public void ConfigureBullet(Transform spawnTransform)
    {
        bulletView.transform.position = spawnTransform.position;
        bulletView.transform.rotation = spawnTransform.rotation;
        bulletView.gameObject.SetActive(true);
    }

    public void UpdateBulletMotion(Transform bulletTransform)
    {
        bulletTransform.Translate(Vector2.up * Time.deltaTime * bulletScriptableObject.speed);
    }

    public void OnBulletEnteredTrigger(GameObject collidedGameObject)
    {
        if (collidedGameObject.GetComponent<EnemyView>() != null)
        {
            collidedGameObject.GetComponent<EnemyView>().TakeBulletDamage(bulletScriptableObject.damage);
            bulletView.gameObject.SetActive(false);
            // TODO: Play particle effects for the bullet hit.
            GameService.Instance.GetVFXService().PlayVFXAtPosition(VFXType.BulletHitExplosion, bulletView.transform.position);
            GameService.Instance.GetPlayerService().ResetPlayerBullet(this);
        }
    }
}