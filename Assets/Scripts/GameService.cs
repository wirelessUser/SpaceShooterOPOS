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
    // TODO: Change Scene name from SampleScene to GameScene.
    // TODO: Make all Services as properties with a private setter, eliminating need of Get***Service() methods. Take example of Player Service & Enemy Service.
    public PlayerService PlayerService { get; private set; }
    public EnemyService EnemyService { get; private set; }
    private DifficultyService difficultyService;
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

    private void Start()
    {
        soundService = new SoundService(soundScriptableObject, audioEffectSource, backgroundMusicSource);
    }

    public void InstantiateGameplayObjects()
    {
        difficultyService = new DifficultyService();
        PlayerService = new PlayerService(playerPrefab, playerScriptableObject, playerBulletPrefab, playerBulletScriptableObject);
        powerUpService = new PowerUpService(powerUpScriptableObject);
        EnemyService = new EnemyService(enemyPrefab, enemyScriptableObject);
        vfxService = new VFXService(vfxScriptableObject);
    }

    private void Update()
    {
        powerUpService?.Update();
        EnemyService?.Update();
    }

    // TODO: Remove all these getters, use properties for C# instead.
    public DifficultyService GetDifficultyService() => difficultyService;

    public PowerUpService GetPowerUpService() => powerUpService;

    public VFXService GetVFXService() => vfxService;

    public SoundService GetSoundService() => soundService;

    public UIService GetUIService() => uiService;

    public void SetTimeScale(int value)
    {
        Time.timeScale = value;
    }
}
