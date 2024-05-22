using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float followDist;
    [SerializeField] float viewHeight;
    Vector2 mouseMovement;

    void Start()
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
        rot.y += mouseMovement.x;

        transform.rotation = Quaternion.Euler(rot);

        if(rot.y < 0)
            rot.y = 360 + rot.y;

        Debug.Log(rot.y);

        var displacement = new Vector3(-Mathf.Cos(90-rot.y), viewHeight, -Mathf.Sin(90-rot.y)) * followDist;

        transform.position = player.transform.position + displacement;
    }
}
