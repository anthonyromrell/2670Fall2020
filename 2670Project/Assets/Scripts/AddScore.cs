using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public IntData scoreValue;

    private void OnTriggerEnter(Collider other)
    {
        scoreValue.value++;
    }
}
