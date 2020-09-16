using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform lookObj;

    private void Update()
    {
        transform.LookAt(lookObj);
        var transformRotation = transform.eulerAngles;
        transformRotation.x = 0;
        transform.rotation = Quaternion.Euler(transformRotation);
    }
}
