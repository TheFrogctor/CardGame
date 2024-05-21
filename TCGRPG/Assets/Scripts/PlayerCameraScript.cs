using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : MonoBehaviour
{
    [SerializeField] Vector2 mouseMovement;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseMovement = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        var rot = transform.rotation.eulerAngles;

        //X spins vertically, Y horizontally, and Z tilts the camera
        rot.x -=mouseMovement.y;
        rot.y +=mouseMovement.x;

        transform.rotation = Quaternion.Euler(rot);
    }
}
