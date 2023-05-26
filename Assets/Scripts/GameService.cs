#region Namespaces
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
#endregion


/// <summary>
/// This is a Service Locator class which provides access to various game-related services.
/// </summary>
public class GameService : GenericMonoSingleton<GameService>
{
    #region Dependencies

    private PlayerService playerService;
    private EnemyService enemyService;
    private PowerUpService powerUpService;
    private VFXService vfxService;
    private SoundService soundService;
    private UIService uiService;

    #endregion

    #region Prefabs
    [SerializeField] private PlayerView playerPrefab;
    [SerializeField] private BulletView playerBulletPrefab;
    [SerializeField] private EnemyView enemyPrefab;
    [SerializeField] private VFXView vfxPrefab;
    #endregion

    #region Scriptable Objects
    [SerializeField] private PlayerScriptableObject playerSO;
    [SerializeField] private BulletScriptableObject playerBulletSO;
    [SerializeField] private EnemyScriptableObject enemySO;
    [SerializeField] private PowerUpScriptableObject powerUpSO;
    [SerializeField] private SoundScriptableObject soundSO;
    #endregion

    #region Scene References
    [SerializeField] private AudioSource audioEffectSource;
    [SerializeField] private AudioSource backgroundMusicSource;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI healthText;
    #endregion

    private void Start()
    {
        // Initialize all Services.
        uiService = new UIService(scoreText, healthText);
        soundService = new SoundService(soundSO, audioEffectSource, backgroundMusicSource);
        playerService = new PlayerService(playerPrefab, playerSO, playerBulletPrefab, playerBulletSO);
        powerUpService = new PowerUpService(powerUpSO);
        enemyService = new EnemyService(enemyPrefab, enemySO);
        vfxService = new VFXService(vfxPrefab);
    }

    private void Update()
    {
        powerUpService?.Update();
        enemyService?.Update();
    }

    #region Getters
    public PlayerService GetPlayerService() => playerService;

    public EnemyService GetEnemyService() => enemyService;

    public PowerUpService GetPowerUpService() => powerUpService;

    public VFXService GetVFXService() => vfxService;

    public SoundService GetSoundService() => soundService;

    public UIService GetUIService() => uiService; 
    #endregion

}
