using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterBehaviour : MonoBehaviour
{
    public float rotateSpeed = 120f, gravity = -9.81f, jumpForce = 10f;
    public FloatData normalSpeed, fastSpeed;
    public IntData playerJumpCount;
    
    protected CharacterController controller;
    protected Vector3 movement;
    protected bool canMove = true;
    protected readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    protected float vInput, hInput;
    protected FloatData moveSpeed;
    
    protected float yVar;
    private int jumpCount;

    private void OnEnable()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
        StartCoroutine(Move());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    protected IEnumerator Move()
    {
        canMove = true;
        while (canMove)
        {
            OnMove();
            yield return wffu;
        }
    }
    
    protected virtual void OnHorizontal()
    {
        //hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        transform.Rotate(0,hInput,0);
    }

    protected virtual void OnVertical()
    {
        vInput = Input.GetAxis("Horizontal")*moveSpeed.value;
        movement.Set(vInput,yVar,0);
    }

    private void OnMove()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = fastSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
        }
        
        OnVertical();
        OnHorizontal();

        yVar += gravity*Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
        {
            yVar = jumpForce;
            jumpCount++;
        }
        
        movement = transform.TransformDirection(movement);
        controller.Move((movement) * Time.deltaTime);
    }
}