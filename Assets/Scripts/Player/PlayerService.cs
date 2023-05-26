using CosmicCuration.Bullets;

namespace CosmicCuration.Player
{
    public class PlayerService
    {
        private PlayerController playerController;

        public PlayerService(PlayerView playerViewPrefab, PlayerScriptableObject playerScriptableObject, BulletView bulletPrefab, BulletScriptableObject bulletScriptableObject)
        {
            playerController = new PlayerController(playerViewPrefab, playerScriptableObject, bulletPrefab, bulletScriptableObject);
        }

        public PlayerController GetPlayerController() => playerController;
        
    } 
}