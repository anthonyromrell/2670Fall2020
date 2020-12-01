using System;
using UnityEngine;
using UnityEngine.Events;

public class FloatBehaviour : MonoBehaviour
{
    public FloatData data;
    public float value = 1f;
    public string otherTag = "enemyHealth";
    public UnityEvent triggerEnterEvent, atZeroEvent;

    private void Start()
    {
        value = data.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(otherTag)) return;
        var otherValue = other.GetComponent<FloatContainer>();
        if (otherValue == null) return;
        UpdateValue(otherValue.data.value);
        triggerEnterEvent.Invoke();
    }

    public void UpdateValue(float number)
    {
        value += number;
        
        if (value <= 0)
        {
            atZeroEvent.Invoke();
        }
    }
}