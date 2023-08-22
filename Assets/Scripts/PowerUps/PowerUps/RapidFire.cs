namespace CosmicCuration.PowerUps
{
    public class RapidFire : PowerUpController
    {
        public RapidFire(PowerUpData powerUpData) : base(powerUpData) { }

        public override void Activate()
        {
            base.Activate();
            GameService.Instance.GetPlayerService().GetPlayerController().ToggleRapidFire(true);
            GameService.Instance.GetUIService().TogglePowerUpUI(true, PowerUpType.RapidFire);
        }

        public override void Deactivate()
        {
            base.Deactivate();
            GameService.Instance.GetPlayerService().GetPlayerController().ToggleRapidFire(false);
            GameService.Instance.GetUIService().TogglePowerUpUI(false, PowerUpType.RapidFire);
        }
    }
}