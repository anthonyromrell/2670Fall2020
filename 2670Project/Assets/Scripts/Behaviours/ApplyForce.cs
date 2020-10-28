using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;
    public Vector3 forces;

    public bool canRunOnStart;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
        if (canRunOnStart)
        {
            OnApplyForce();
        }
    }

    public void OnApplyForce()
    {
        rBody.AddRelativeForce(forces);
    }
}