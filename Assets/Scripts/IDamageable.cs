/// <summary>
/// An Interface representing anything that can take damage.
/// </summary>
public interface IDamageable
{
    /// <summary>
    /// Reduces Health by the given amount.
    /// </summary>
    /// <param name="damageToTake"></param>
    public void TakeDamage(int damageToTake);
}