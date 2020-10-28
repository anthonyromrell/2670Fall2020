using System;
using System.Collections;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
       
    }

    public void OnDisable()
    {
        Destroy(gameObject);
    }
}
