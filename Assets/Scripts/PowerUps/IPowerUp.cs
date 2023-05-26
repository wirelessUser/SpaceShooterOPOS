namespace CosmicCuration.PowerUps
{
    /// <summary>
    /// To be implemented by all PowerUp Controllers.
    /// </summary>
    public interface IPowerUp
    {
        public void Activate();

        public void Deactivate();
    } 
}