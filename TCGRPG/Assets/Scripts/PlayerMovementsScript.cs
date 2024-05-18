using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementsScript : MonoBehaviour
{

    private Vector2 moveInput;
    private Rigidbody2D rb;

    private Vector2 targetMovement;
    private Vector2 currentMovement;

    // public Collider3D playerCollider;

    [Header("Movement Variables")]
    public float moveSpeed;
    public float accelleration;
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        targetMovement = moveInput * moveSpeed;
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {

        currentMovement = Vector2.MoveTowards(currentMovement, targetMovement, accelleration * Time.fixedDeltaTime);

        rb.velocity = currentMovement;
    }

    public void Shove(Vector2 force)
    {
        currentMovement += force;
    }
}
