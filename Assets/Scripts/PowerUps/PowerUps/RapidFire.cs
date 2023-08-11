namespace CosmicCuration.PowerUps
{
    public class RapidFire : PowerUpController
    {
        public RapidFire(PowerUpData powerUpData) : base(powerUpData) { }

        public override void Activate()
        {
            base.Activate();
            GameService.Instance.GetPlayerService().GetPlayerController().ToggleRapidFire(true);
            GameService.Instance.GetUIService().GetGameplayUiController().EnablePowerUpUi(PowerUpType.RapidFire);
        }

        public override void Deactivate()
        {
            base.Deactivate();
            GameService.Instance.GetPlayerService().GetPlayerController().ToggleRapidFire(false);
            GameService.Instance.GetUIService().GetGameplayUiController().DisablePowerUpUi(PowerUpType.RapidFire);
        }
    } 
}