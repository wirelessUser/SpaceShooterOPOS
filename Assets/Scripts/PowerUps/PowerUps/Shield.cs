public class Shield : PowerUpController
{
    public Shield(PowerUpView shieldPrefab, float activeDuration) : base(shieldPrefab, activeDuration) { }

    public override void Activate()
    {
        GameService.Instance.GetPlayerService().GetPlayerController().ToggleShield(true);
    }

    public override void Deactivate()
    {
        GameService.Instance.GetPlayerService().GetPlayerController().ToggleShield(false);
    }
}