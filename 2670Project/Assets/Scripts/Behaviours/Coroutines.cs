using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    public int counter = 100;
    private WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private WaitForSeconds wfs = new WaitForSeconds(1f);
    private IEnumerator Start()
    {
        while (counter > 0)
        {
            yield return wffu;
            transform.Translate(0.1f,0,0);
            counter--;
        }

        yield return wfs;
        
        while (counter < 100)
        {
            yield return wffu;
            transform.Translate(-0.1f,0,0);
            counter++;
        }

        yield return wfs;
        
        StartCoroutine(Start());
    }
}
