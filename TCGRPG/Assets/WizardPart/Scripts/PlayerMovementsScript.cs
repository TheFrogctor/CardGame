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

        targetMovement = moveInput * moveSpeed;
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
        var rot = transform.rotation.eulerAngles;

        rot.y = playerID.yRotation;

        transform.rotation = Quaternion.Euler(rot);
    }
}
