using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;
    private Rigidbody2D body;

    public float moveSpeed = 5f;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        body.linearVelocity = Vector2.ClampMagnitude(moveInput, 1f) * moveSpeed;
    }
}