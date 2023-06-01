using UnityEngine;

namespace CosmicCuration.Bullets
{
    public interface IBullet
    {
        public void UpdateBulletMotion();

        public void OnBulletEnteredTrigger(GameObject collidedObject);
    }
}