public interface IPowerUp
{
    /// <summary>
    /// Implement this method to Activate a PowerUp.
    /// </summary>
    /// <param name="activeDuration"></param>
    public void Activate();

    /// <summary>
    /// Implement this method to Deactivate a PowerUp.
    /// </summary>
    public void Deactivate();
}