using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void SetValueFromTransform(Vector3 obj)
    {
        value = obj;
    }

    public void SetValueFromRotation(Transform obj)
    {
        value = obj.eulerAngles;
    }
}