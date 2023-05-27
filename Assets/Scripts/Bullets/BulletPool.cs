using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.Bullets
{
    public class BulletPool
    {
        private BulletView bulletPrefab;
        private BulletScriptableObject bulletSO;
        private List<PooledBullets> pooledBullets = new List<PooledBullets>();

        public BulletPool(BulletView bulletPrefab, BulletScriptableObject bulletSO)
        {
            this.bulletPrefab = bulletPrefab;
            this.bulletSO = bulletSO;
        }

        public BulletController GetBullet()
        {
            if (pooledBullets.Count > 0)
            {
                PooledBullets item = pooledBullets.Find(item => !item.isUsed);
                if (item != null)
                {
                    item.isUsed = true;
                    return item.Item;
                }
            }
            return CreateNewPooledBullet();
        }

        private BulletController CreateNewPooledBullet()
        {
            PooledBullets newBullet = new PooledBullets();
            newBullet.Item = CreateBullet();
            newBullet.isUsed = true;
            pooledBullets.Add(newBullet);
            return newBullet.Item;
        }

        private BulletController CreateBullet() => return new BulletController(bulletPrefab, bulletSO);

        public class PooledBullets
        {
            public BulletController Item;
            public bool isUsed;
        }
    }
}