using UnityEngine;
using TMPro;

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
    [SerializeField] private EnemyView enemyPrefab;
    [SerializeField] private BulletView playerBulletPrefab;

    #endregion

    #region Scriptable Objects

    [SerializeField] private PlayerScriptableObject playerSO;
    [SerializeField] private EnemyScriptableObject enemySO;
    [SerializeField] private BulletScriptableObject playerBulletSO;
    [SerializeField] private PowerUpScriptableObject powerUpSO;
    [SerializeField] private VFXScriptableObject vfxSO;
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
        playerService = new PlayerService(playerPrefab, playerSO, playerBulletPrefab, playerBulletSO);
        enemyService = new EnemyService(enemyPrefab, enemySO);
        powerUpService = new PowerUpService(powerUpSO);
        vfxService = new VFXService(vfxSO);
        soundService = new SoundService(soundSO, audioEffectSource, backgroundMusicSource);
        uiService = new UIService(scoreText, healthText);
    }

    public PlayerService GetPlayerService() => playerService;

    public EnemyService GetEnemyService() => enemyService;

    public PowerUpService GetPowerUpService() => powerUpService;

    public VFXService GetVFXService() => vfxService;

    public SoundService GetSoundService() => soundService;

    public UIService GetUIService() => uiService;
}
