using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicCuration.Bullets
{
    public class BulletPool
    {
        private BulletView bulletPrefab;
        private BulletScriptableObject bulletSO;
        private List<PooledBullet> pooledBullets = new List<PooledBullet>();

        public BulletPool(BulletView bulletPrefab, BulletScriptableObject bulletSO)
        {
            this.bulletPrefab = bulletPrefab;
            this.bulletSO = bulletSO;
        }

        public BulletController GetBullet()
        {
            if (pooledBullets.Count > 0)
            {
                PooledBullet item = pooledBullets.Find(item => !item.isUsed);
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
            PooledBullet newBullet = new PooledBullet();
            newBullet.Item = CreateBullet();
            newBullet.isUsed = true;
            pooledBullets.Add(newBullet);
            return newBullet.Item;
        }

        private BulletController CreateBullet() => new BulletController(bulletPrefab, bulletSO);

        public void ReturnBullet(BulletController bullet)
        {
            PooledBullet pooledBullet = pooledBullets.Find(i => i.Item.Equals(bullet));
            pooledBullet.isUsed = false;
        }

        public class PooledBullet
        {
            public BulletController Item;
            public bool isUsed;
        }
    }
}