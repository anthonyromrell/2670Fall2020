using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
       public UnityEvent startEvent, onEnableEvent;

       private void Start()
       {
              startEvent.Invoke();
       }

       private void OnEnable()
       {
              onEnableEvent.Invoke();
       }
}