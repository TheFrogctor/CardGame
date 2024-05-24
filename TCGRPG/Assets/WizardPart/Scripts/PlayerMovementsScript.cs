using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementsScript : PlayerSystems
{

    private Vector3 moveInput;
    private Rigidbody rb;

    private Vector3 targetMovement;
    private Vector3 currentMovement;

    // public Collider3D playerCollider;

    [Header("Movement Variables")]
    public float moveSpeed;
    public float accelleration;

    void Awake()
    {
        rb = transform.GetComponent<Rigidbody>();
    }


    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        // moveInput.x *=  Mathf.Cos(playerID.yRotation  * Mathf.Deg2Rad);
        // moveInput.z *=  Mathf.Sin(playerID.yRotation  * Mathf.Deg2Rad);

        var moveDirection = new Vector3();
        moveDirection.x = moveInput.x * Mathf.Sin((playerID.yRotation + 90)  * Mathf.Deg2Rad) + moveInput.z * Mathf.Sin(playerID.yRotation  * Mathf.Deg2Rad);
        moveDirection.z = moveInput.x * Mathf.Cos((playerID.yRotation + 90)  * Mathf.Deg2Rad) + moveInput.z * Mathf.Cos(playerID.yRotation  * Mathf.Deg2Rad);

        moveDirection.Normalize();

        targetMovement = moveDirection * moveSpeed;
    }

    void FixedUpdate()
    {
        Move();

        Look();
    }

    private void Move()
    {

        currentMovement = Vector3.MoveTowards(currentMovement, targetMovement, accelleration * Time.fixedDeltaTime);

        rb.velocity = currentMovement;
    }

    public void Shove(Vector3 force)
    {
        currentMovement += force;
    }

    private void Look()
    {
        if(rb.velocity.sqrMagnitude > 0)
        {
            Quaternion targetRotation = Quaternion.Euler(0, Mathf.Atan2(rb.velocity.x, rb.velocity.z) * Mathf.Rad2Deg, 0);

            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, moveSpeed * Time.fixedDeltaTime);
        }
    }
}
