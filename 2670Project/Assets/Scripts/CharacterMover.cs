using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;
    public float gravity = 9.81f;
    public float moveSpeed = 3f;
    public float fastMoveSpeed;
    public float jumpForce = 10f;
    public int jumpCountMax;
    public float rotateSpeed = 3f;
    private Vector3 rotateMovement;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        movement.Set(moveSpeed*Input.GetAxis("Vertical"),0,0);
        rotateMovement.y = rotateSpeed * Input.GetAxis("Horizontal");
        controller.transform.Rotate(rotateMovement*Time.deltaTime);
        movement = controller.transform.TransformDirection(movement);
        
        controller.Move(movement*Time.deltaTime);
    }
}