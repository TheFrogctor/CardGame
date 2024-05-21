using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementsScript : MonoBehaviour
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
        moveInput.z = -Input.GetAxisRaw("Horizontal");
        moveInput.x = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        targetMovement = moveInput * moveSpeed;
    }

    void FixedUpdate()
    {
        Move();
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
}
