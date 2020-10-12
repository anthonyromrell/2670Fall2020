using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIPatrol : MonoBehaviour
{
    private NavMeshAgent agent;
    public List<Transform> patrolPoints;
    
    private void Start()
    {
        i = 0;
        agent = GetComponent<NavMeshAgent>();
    }

    private int i = 0;
    private void Update()
    {
        if (agent.pathPending || !(agent.remainingDistance < 0.5f)) return;
        agent.destination = patrolPoints[i].position;
        i = (i + 1) % patrolPoints.Count;
    }
}
