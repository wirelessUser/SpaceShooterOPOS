using UnityEngine;

/// <summary>
/// Represents the view component of a bullet object.
/// </summary>
public class BulletView : MonoBehaviour
{
    private BulletController bulletController;

    public void SetController(BulletController bulletController) => this.bulletController = bulletController;
    
    private void Update() => bulletController?.UpdateBulletMotion(this.transform);

    private void OnTriggerEnter2D(Collider2D collision) => bulletController?.OnBulletEnteredTrigger(collision.gameObject);
}