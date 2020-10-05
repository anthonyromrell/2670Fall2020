using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

    public float rotateSpeed = 30f, gravity = -9.81f, jumpForce = 10f;
    private float yVar;

    public FloatData normalSpeed, fastSpeed;
    private FloatData moveSpeed;
    
    public IntData playerJumpCount;
    private int jumpCount;

    private void Start()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = fastSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
        }
        
        var vInput = Input.GetAxis("Vertical")*moveSpeed.value;
        var hInput = Input.GetAxis("Horizontal")*moveSpeed.value;
        movement.Set(hInput,yVar,vInput);
        
        // var hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        // transform.Rotate(0,hInput,0);

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
        controller.Move((movement + knockBackMovement) * Time.deltaTime);
    }

    public float playerKnockBackForce = 10f;
    private Vector3 knockBackMovement;
    private IEnumerator KnockBack (ControllerColliderHit hit)
    {
        var i = 2f;
        knockBackMovement = hit.collider.attachedRigidbody.velocity * (i * playerKnockBackForce);
        while (i > 0)
        {
            yield return new WaitForFixedUpdate();
            i -= 0.1f;
        }
    }
    
    public float pushPower = 10.0f;
    private CharacterController characterController;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
        {
            return;
        }

        if (hit.moveDirection.y < -0.3)
        {
            return;
        }
        
        StartCoroutine(KnockBack(hit));
        
        var pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        var forces = pushDir * pushPower;
        body.AddRelativeForce(forces);
        body.AddTorque(forces);
    }
}