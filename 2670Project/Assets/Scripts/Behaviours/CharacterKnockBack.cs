using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterKnockBack : MonoBehaviour
{
    private CharacterController controller;

    Vector3 movement = Vector3.zero;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    private IEnumerator KnockBack (ControllerColliderHit hit)
    {
        var i = 2f;
        movement = hit.collider.attachedRigidbody.velocity*i;
        while (i > 0)
        {
            yield return new WaitForFixedUpdate();
            i -= 0.1f;
            controller.Move(movement);
        }
        movement = Vector3.zero;
    }
    
    public float pushPower = 10.0f;

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
        body.velocity = forces;
    }
}