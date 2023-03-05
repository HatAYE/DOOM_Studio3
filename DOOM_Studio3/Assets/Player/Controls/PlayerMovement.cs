using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody PlayerRB;

    public float speed;
    public float SprintSpeed;
    public float MoveSpeed;

    public float MaxDashDistance;
    public float DashSpeed;
    public bool isDashing;

    public float mouseSensitivity = 100f;

    float xRotation = 0f;


    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        CameraMovement();
        PlayerRB.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * MoveSpeed, 0, Input.GetAxisRaw("Vertical"));
    }

    private void CameraMovement()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;



        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        transform.Rotate(Vector3.up * mouseX);
    }
}
