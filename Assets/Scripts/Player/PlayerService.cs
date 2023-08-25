using CosmicCuration.Bullets;
using UnityEngine;

namespace CosmicCuration.Player
{
    public class PlayerService
    {
        private PlayerController playerController;

        private int currentScore;

        public PlayerService(PlayerView playerViewPrefab, PlayerScriptableObject playerScriptableObject, BulletView bulletPrefab, BulletScriptableObject bulletScriptableObject)
        {
            playerController = new PlayerController(playerViewPrefab, playerScriptableObject, bulletPrefab, bulletScriptableObject);
            UpdateHighScore();
        }

        public PlayerController GetPlayerController() => playerController;

        private void UpdateHighScore()
        {
            int score = PlayerPrefs.GetInt("HighScore", 0);
            GameService.Instance.UIService.UpdateHighScoreUI(score);
        }

       public void UpdateScoreValue(int score)
        {
            currentScore = score;
            GameService.Instance.UIService.UpdateScoreUI(score);
        }

        public int GetHighScore()
        {
            int highScore = PlayerPrefs.GetInt("HighScore", 0);

            if (currentScore > highScore)
                highScore = currentScore;

            return highScore;
        }
        
        public Vector3 GetPlayerPosition() => playerController.GetPlayerPosition();
    } 
}