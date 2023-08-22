using UnityEngine;
using TMPro;
using CosmicCuration.Audio;
using CosmicCuration.Enemy;
using CosmicCuration.Bullets;
using CosmicCuration.VFX;
using CosmicCuration.Player;
using CosmicCuration.UI;
using CosmicCuration.Utilities;
using CosmicCuration.PowerUps;


public class GameService : GenericMonoSingleton<GameService>
{

    private PlayerService playerService;
    private EnemyService enemyService;
    private PowerUpService powerUpService;
    private VFXService vfxService;
    private SoundService soundService;

    [SerializeField] private UIService uiService;

    [SerializeField] private PlayerView playerPrefab;
    [SerializeField] private BulletView playerBulletPrefab;
    [SerializeField] private EnemyView enemyPrefab;

    [SerializeField] private PlayerScriptableObject playerScriptableObject;
    [SerializeField] private BulletScriptableObject playerBulletScriptableObject;
    [SerializeField] private EnemyScriptableObject enemyScriptableObject;
    [SerializeField] private PowerUpScriptableObject powerUpScriptableObject;
    [SerializeField] private SoundScriptableObject soundScriptableObject;
    [SerializeField] private VFXScriptableObject vfxScriptableObject;
 
    [SerializeField] private AudioSource audioEffectSource;
    [SerializeField] private AudioSource backgroundMusicSource;

    public DifficultyState currentDifficultyState;

    private void Start()
    {
        soundService = new SoundService(soundScriptableObject, audioEffectSource, backgroundMusicSource);
    }

    public void InstantiateGameplayObjects()
    {
        SetDifficultyVariable();
        playerService = new PlayerService(playerPrefab, playerScriptableObject, playerBulletPrefab, playerBulletScriptableObject);
        powerUpService = new PowerUpService(powerUpScriptableObject);
        enemyService = new EnemyService(enemyPrefab, enemyScriptableObject);
        vfxService = new VFXService(vfxScriptableObject);
    }

    private void Update()
    {
        powerUpService?.Update();
        enemyService?.Update();
    }

    public PlayerService GetPlayerService() => playerService;

    public EnemyService GetEnemyService() => enemyService;

    public PowerUpService GetPowerUpService() => powerUpService;

    public VFXService GetVFXService() => vfxService;

    public SoundService GetSoundService() => soundService;

    public UIService GetUIService() => uiService;

    private void SetDifficultyVariable()
    {
        switch (currentDifficultyState)
        {
            case DifficultyState.Easy:
                // changing data values here
                break;
            case DifficultyState.Medium:
                // changing data values here
                break;
            case DifficultyState.Hard:
                // changing data values here
                break;
        }
    }

    public void SetTimeScale(int value)
    {
        Time.timeScale = value;
    }
}
