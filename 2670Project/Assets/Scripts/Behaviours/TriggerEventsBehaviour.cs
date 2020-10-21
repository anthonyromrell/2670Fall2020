using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
     public UnityEvent triggerEnterEvent, triggerExitEvent;
     public float delayTime = 0.01f;
     private WaitForSeconds waitObj;

     private void Start()
     {
          waitObj = new WaitForSeconds(delayTime);
     }
     
     private IEnumerator OnTriggerEnter(Collider other)
     {
          yield return waitObj;
          triggerEnterEvent.Invoke();
     }

     private void OnTriggerExit(Collider other)
     {
          triggerExitEvent.Invoke();
     }
}