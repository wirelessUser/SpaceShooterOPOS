namespace CosmicCuration.PowerUps
{
    public class DoubleTurret : PowerUpController
    {
        public DoubleTurret(PowerUpData powerUpData) : base(powerUpData) { }

        public override void Activate()
        {
            base.Activate();
            GameService.Instance.GetPlayerService().GetPlayerController().ToggleDoubleTurret(true);
            GameService.Instance.GetUIService().GetGameplayUiController().EnablePowerUpUI(PowerUpType.DoubleTurret);
        }

        public override void Deactivate()
        {
            base.Deactivate();
            GameService.Instance.GetPlayerService().GetPlayerController().ToggleDoubleTurret(false);
            GameService.Instance.GetUIService().GetGameplayUiController().DisablePowerUpUI(PowerUpType.DoubleTurret);
        }
    } 
}