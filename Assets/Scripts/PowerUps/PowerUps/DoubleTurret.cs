public class DoubleTurret : PowerUpController
{
    public DoubleTurret(PowerUpView shieldPrefab, float activeDuration) : base(shieldPrefab, activeDuration) { }

    public override void Activate()
    {
        GameService.Instance.GetPlayerService().GetPlayerController().ToggleDoubleTurret(true);
    }

    public override void Deactivate()
    {
        GameService.Instance.GetPlayerService().GetPlayerController().ToggleDoubleTurret(false);
    }
}