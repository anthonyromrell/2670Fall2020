using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointFromMouse : MonoBehaviour
{
    public Vector3Data mouseLocation;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition),out var hit, 100))
        {    
            mouseLocation.value = hit.point;
        }
    }
}
