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
    public GameObject PlayerCam;
    public GameObject DashCam;

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
        //PlayerRB.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * MoveSpeed, 0, Input.GetAxisRaw("Vertical"));
        
    }
}
