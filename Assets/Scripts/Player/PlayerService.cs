using CosmicCuration.Bullets;

namespace CosmicCuration.Player
{
    public class PlayerService
    {
        private PlayerController playerController;
        private BulletPool playerBulletPool;

        public PlayerService(PlayerView playerViewPrefab, PlayerScriptableObject playerScriptableObject, BulletView bulletPrefab, BulletScriptableObject bulletScriptableObject)
        {
            playerBulletPool = new BulletPool(bulletPrefab, bulletScriptableObject);
            playerController = new PlayerController(playerViewPrefab, playerScriptableObject, playerBulletPool);
        }

        public PlayerController GetPlayerController() => playerController;


        public void ResetPlayerBullet(BulletController bulletToReset)
        {
            playerBulletPool.ReturnItem(bulletToReset);
        }
    } 
}