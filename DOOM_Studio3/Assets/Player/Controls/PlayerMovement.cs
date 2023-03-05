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

    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        PlayerRB.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * MoveSpeed, 0, Input.GetAxisRaw("Vertical"));
    }
}
