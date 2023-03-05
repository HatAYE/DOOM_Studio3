using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    Rigidbody PlayerRB;
    public GameObject DashCam;

    public float speed;
    public float SprintSpeed;
    public float MoveSpeed;

    public float groundDistance = 0.4f;
    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundMask;

    public float MaxDashDistance;
    public float DashSpeed;
    public bool isDashing;

    public float gravity;
    public float jumpdist;

    public GameObject HUD;
    public GameObject PauseMenuOBJ;
    Vector3 velocity;


    private void Start()
    {
        MoveSpeed = speed;
        controller = gameObject.GetComponent<CharacterController>();
        PlayerRB = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Ground Check
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        /*
         * Gravity
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        */

        /*
        * Crouch
        if (Input.GetKeyDown(KeyCode.C))
        {
            controller.height = 0.5f;
            speed = 5f;
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            controller.height = 2.0f;
            speed = 12f;
        }
        */

        /*
         * Jump
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = jumpdist;
        }
        */

        /*
         * Pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuOBJ.SetActive(true);
            HUD.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            Time.timeScale = 0;
        }
        */

        //Dash
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, MaxDashDistance) && Input.GetKey(KeyCode.Space))
        {
            if (hit.collider.CompareTag("Enemy"))
            {
                if (Vector3.Distance(gameObject.transform.position, hit.collider.gameObject.transform.position) > 0.00001f)
                {
                    Debug.DrawLine(Camera.main.transform.position, hit.point, Color.green);
                    DashCam.GetComponent<CinemachineVirtualCamera>().LookAt = hit.collider.gameObject.transform;
                    isDashing = true;
                    gravity = 0f;
                    Vector3 DashDirection = (hit.collider.gameObject.transform.position - gameObject.transform.position).normalized;
                    PlayerRB.transform.position += DashDirection * DashSpeed * Time.deltaTime;
                }
            }
        }
        else
        {
            DashCam.GetComponent<CinemachineVirtualCamera>().LookAt = null;
            isDashing = false;
            gravity = 9;
        }

        //Sprint
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            MoveSpeed = SprintSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            MoveSpeed = speed;
        }

        //Movement
        if (!isDashing)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = Camera.main.transform.right * x + Camera.main.transform.forward * z;

            controller.Move(move * MoveSpeed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }
}