using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
       public UnityEvent awakeEvent, startEvent, onEnableEvent, onDisableEvent;
       public float holdTime = 1f;
       public bool repeatOnStart;

       private void Awake()
       {
              awakeEvent.Invoke();
       }

       public void Restart()
       {
              StartCoroutine(Start());
       }
       
       private IEnumerator Start()
       {
              yield return new WaitForSeconds(holdTime);
              startEvent.Invoke();

              while (repeatOnStart)
              { 
                     yield return new WaitForSeconds(holdTime);
                     startEvent.Invoke();
              }
       }
       private void OnEnable()
       {
              onEnableEvent.Invoke();
       }

       private void OnDisable()
       {
              onEnableEvent.Invoke();
       }
}