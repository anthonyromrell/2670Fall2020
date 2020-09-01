using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;
    public float gravity = -9.81f;
    public float moveSpeed = 3f;
    public float fastMoveSpeed;
    public float jumpForce = 1f;
    public int jumpCountMax = 2;
    public int jumpCount;
    public float rotateSpeed = 3f;
    private Vector3 rotateMovement;
    private bool groundedPlayer;
    private float yVar;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        
        movement.Set(moveSpeed*Input.GetAxis("Vertical"),yVar,0);
        rotateMovement.y = rotateSpeed * Input.GetAxis("Horizontal");
        controller.transform.Rotate(rotateMovement*Time.deltaTime);
        movement = controller.transform.TransformDirection(movement);

        groundedPlayer = controller.isGrounded;
        
        if (groundedPlayer && movement.y < 0)
        {
            yVar = 0f;
        }
        
        yVar += gravity * Time.deltaTime;
        
        if (Input.GetButton("Jump") && groundedPlayer)
        {
            yVar += Mathf.Sqrt(jumpForce * -3.0f * gravity);
        }
        controller.Move(movement*Time.deltaTime);
    }
}