using UnityEngine;

/// <summary>
/// Handles buisness logic for a bullet.
/// </summary>
public class BulletController
{
    private BulletView bulletView;
    private BulletScriptableObject bulletScriptableObject;

    public BulletController(BulletView bulletViewPrefab, BulletScriptableObject bulletScriptableObject)
    {
        bulletView = Object.Instantiate(bulletViewPrefab);
        bulletView.SetController(this);
        this.bulletScriptableObject = bulletScriptableObject;
    }

    public void UpdateBulletMotion(Transform bulletTransform)
    {
        bulletTransform.Translate(Vector2.up * Time.deltaTime * bulletScriptableObject.speed);
    }

    public void OnBulletEnteredTrigger(GameObject collidedGameObject)
    {
        // TODO: Implement bullet-trigger collision logic.
    }

}