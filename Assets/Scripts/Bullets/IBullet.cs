using UnityEngine;

namespace CosmicCuration.Bullets
{
    /// <summary>
    /// Interface to be Implemented by a Bullet Controller.
    /// </summary>
    public interface IBullet
    {
        /// <summary>
        /// Updates the motion of the bullet.
        /// </summary>
        public void UpdateBulletMotion(Transform bulletTransform);

        /// <summary>
        /// Handles the event when the bullet enters a trigger collider.
        /// </summary>
        /// <param name="collidedGameObject">The game object the bullet collided with.</param>
        public void OnBulletEnteredTrigger(GameObject collidedObject);
    }
}