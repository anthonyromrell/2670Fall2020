using System;
using UnityEngine;

public class Ride : MonoBehaviour
{
    private Vector3 position, rotation;
    private bool direction;
    public float moveSpeed = 3f, rotateSpeed = 12f, maxHeight = 5f;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var limit = transform.position;
        
        position.y = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        rotation.y = rotateSpeed * Time.deltaTime;
        transform.Rotate(rotation);
        controller.Move(position);
    }
}
