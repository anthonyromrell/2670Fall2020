using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void SetValueFromVector3(Vector3 obj)
    {
        value = obj;
    }

    public void SetValueFromPosition(Transform obj)
    {
        value = obj.position;
    }
    
    public void SetPositionFromValue(Transform obj)
    {
        obj.position = value;
    }

    public void SetValueFromRotation(Transform obj)
    {
        value = obj.eulerAngles;
    }
    
    public void SetFromMousePosition(Camera cam)
    {
        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition),out var hit, 100))
        {    
            value = hit.point;
        }
    }
}