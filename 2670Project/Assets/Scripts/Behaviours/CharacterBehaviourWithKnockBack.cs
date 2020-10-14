using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterBehaviourWithKnockBack : CharacterBehaviour
{
    public float pushPower = 10.0f;
    private IEnumerator KnockBack (ControllerColliderHit hit, Rigidbody body)
    {
        canMove = false;
        var i = 2f;
       
        movement = -hit.moveDirection;
        movement.y = -1;
        while (i > 0)
        {
            yield return wffu;
            i -= 0.1f;
            controller.Move((movement) * Time.deltaTime);
            
            var pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
            var forces = pushDir * pushPower;
            body.AddForce(forces);
        }
        movement = Vector3.zero;
        StartCoroutine(Move());
    }

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
        StartCoroutine(KnockBack(hit, body));
    }
}