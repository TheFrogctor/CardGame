using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : PlayerSystems
{
    [SerializeField] GameObject player;
    [SerializeField] float followDist;
    [SerializeField] float viewHeight;
    [SerializeField] float sensitivity;
    Vector2 mouseMovement;

    protected override void Start()
    {
        playerID = player.GetComponent<PlayerBuild>().player;
    }

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        viewHeight /= 5;
    }

    void Update()
    {
        mouseMovement = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        var rot = transform.rotation.eulerAngles;

        //X spins vertically, Y horizontally, and Z tilts the camera
        rot.x -= mouseMovement.y;
        rot.y += mouseMovement.x * sensitivity;

        transform.rotation = Quaternion.Euler(rot);

        if(rot.y < 0)
            rot.y = 360 + rot.y;

        var displacement = new Vector3(-Mathf.Cos((90-rot.y) * Mathf.Deg2Rad), viewHeight, -Mathf.Sin((90-rot.y) * Mathf.Deg2Rad)) * followDist;

        transform.position = player.transform.position + displacement;

        playerID.yRotation = rot.y;
    }
}
