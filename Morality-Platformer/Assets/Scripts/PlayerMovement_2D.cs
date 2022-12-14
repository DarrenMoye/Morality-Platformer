using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_2D : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5.0f;
    [SerializeField] private float jumpPower = 1.0f;

    private Rigidbody _playerRigidbody;
    private void Start()
    { 
        _playerRigidbody = GetComponent<Rigidbody>();
        if (_playerRigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody component");
        }
    }
    private void Update()
    {
        MovePlayer();

        if (Input.GetKey("space"))
        {
            Jump();
        }
    }
    private void MovePlayer()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        _playerRigidbody.velocity = new Vector2(horizontalInput * playerSpeed, _playerRigidbody.velocity.y);

    }

    private void Jump()
    {
        _playerRigidbody.velocity = new Vector2(0, jumpPower);
    }
}


