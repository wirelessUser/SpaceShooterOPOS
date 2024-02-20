

using System.Collections.Generic;

namespace CosmicCuration.Bullets
{
    public class BulletPool
    {
        public BulletView bulletView;
        public BulletScriptableObject bulletSo;

        public List<PooledBullet> pooledBulletList = new List<PooledBullet>();



        public BulletPool(BulletView bulletView, BulletScriptableObject bulletSo)
        {
            this.bulletView = bulletView;
            this.bulletSo = bulletSo;
        }
    }





    public class PooledBullet
    {
        public BulletController bulletController;
        public bool isUsed;
    }
}
