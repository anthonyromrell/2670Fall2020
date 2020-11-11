using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class InstancerBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public float holdTime = 0.5f;
    public UnityEvent startEvent, onCallEvent, restartLoopEvent;
    public int instanceCount = 10;
    private int counter = 0;
    
    private WaitForSeconds wfs;
    
    private void Start()
    {
        wfs = new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }

    public void StartLoopEvents()
    {
        StartCoroutine(CallInstanceEvent());
    }
    
    private IEnumerator CallInstanceEvent()
    {
        while (counter < instanceCount)
        {
            onCallEvent.Invoke();
            counter++;
            yield return wfs;
        }
        counter = 0;
        restartLoopEvent.Invoke();
    }
    
    public void Instance()
    {
        var location = transform.position;
        var newObj = Instantiate(prefab);
    }
}