using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] public Transform canonTransform;
    [SerializeField] public Transform turretTransform1;
    [SerializeField] public Transform turretTransform2;

    private PlayerController playerController;

    public void SetController(PlayerController playerController)
    {
        this.playerController = playerController;
    }

    private void Update()
    {
        HandlePlayerInput();
    }

    /// <summary>
    /// Checks for movement and fire input and tells the PlayerController to handle the logic accordingly.
    /// </summary>
    private void HandlePlayerInput()
    {
        // TODO: Implement player input handling
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerController.OnPlayerCollided(collision.gameObject);
    }

}