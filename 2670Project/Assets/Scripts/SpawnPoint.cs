using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3Data vData;
    
    //Set the vData from the position value on start

    private void OnTriggerEnter(Collider other)
    {
        //set the location data of the player to the current spawnPoint
    }
}