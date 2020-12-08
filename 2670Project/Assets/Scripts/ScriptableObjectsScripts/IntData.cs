using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    public UnityEvent maxValueEvent;

    public void ResetValue (int number)
    {
        value = number;
    }

    public void UpdateIntPlusOne (int maxValue)
    {
        value++;
        if (value == maxValue)
        {
            Debug.Log("Run");
            maxValueEvent.Invoke();
        }
    }
}