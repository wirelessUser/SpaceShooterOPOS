public class DoubleTurret : PowerUpController
{
    public DoubleTurret(PowerUpView shieldPrefab, float activeDuration) : base(shieldPrefab, activeDuration) { }

    public override void Activate()
    {
        base.Activate();
        GameService.Instance.GetPlayerService().GetPlayerController().ToggleDoubleTurret(true);
    }

    public override void Deactivate()
    {
        base.Deactivate();
        GameService.Instance.GetPlayerService().GetPlayerController().ToggleDoubleTurret(false);
    }
}