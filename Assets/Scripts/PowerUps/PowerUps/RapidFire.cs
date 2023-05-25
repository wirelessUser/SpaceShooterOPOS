namespace CosmicCuration.PowerUps
{
    public class RapidFire : PowerUpController
    {
        public RapidFire(PowerUpView shieldPrefab, float activeDuration) : base(shieldPrefab, activeDuration) { }

        public override void Activate()
        {
            base.Activate();
            GameService.Instance.GetPlayerService().GetPlayerController().ToggleRapidFire(true);
        }

        public override void Deactivate()
        {
            base.Deactivate();
            GameService.Instance.GetPlayerService().GetPlayerController().ToggleRapidFire(false);
        }
    } 
}