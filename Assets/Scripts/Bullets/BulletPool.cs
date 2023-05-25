using UnityEngine;
using CosmicCuration.Utilities;

namespace CosmicCuration.Bullets
{
    public class BulletPool : GenericObjectPool<BulletController>
    {
        private BulletView bulletViewPrefab;
        private BulletScriptableObject bulletScriptableObject;

        public BulletPool(BulletView bulletPrefab, BulletScriptableObject bulletScriptableObject)
        {
            this.bulletViewPrefab = bulletPrefab;
            this.bulletScriptableObject = bulletScriptableObject;
        }

        public BulletController GetBullet()
        {
            return GetItem<BulletController>();
        }

        protected override BulletController CreateItem<IT>()
        {
            BulletController newBulletController = new BulletController(bulletViewPrefab, bulletScriptableObject);
            return newBulletController;
        }

    } 
}