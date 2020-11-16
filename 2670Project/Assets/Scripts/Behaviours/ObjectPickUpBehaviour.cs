using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ObjectPickUpBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    private bool canPickUp;
    
    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        canPickUp = Input.GetKey(KeyCode.E);
    }

    private void OnTriggerStay(Collider other)
    {
        if (canPickUp)
        {
            transform.parent = other.transform;
            rBody.Sleep();
        }
        else
        {
            transform.parent = null;
            rBody.WakeUp();
        }
    }
}
